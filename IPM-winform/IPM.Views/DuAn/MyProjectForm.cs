﻿using IPM.Infrastructure.EntityFrameworkDataAccess;
using IPM_winform.IPM.Infrastructure;
using IPM_winform.IPM.Infrastructure.Entities;
using IPM_winform.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_winform.IPM.Views.DuAn
{
    public class MyProjectForm : ProjectForm
    {
        private readonly AppDBContext db = AppDbContextSingleton.GetInstance();
        public override IEnumerable<Project> RowsProject()
        {

            var user = Session.getSession();
            var userFromDb = db.Users
                .Include(e => e.Participations)
                .ThenInclude(e => e.Project)
                .ThenInclude(e => e.AffiliatedUnit)
                .Where(e => e.UserId == user.UserId)
                .FirstOrDefault();
            return userFromDb.Participations.Select(e => e.Project);
        }

        public IEnumerable<Participation> RowsParticipation()
        {

            var user = Session.getSession();
            var part = db.Participations                
                .Include(e => e.Project)
                .ThenInclude(e => e.Files)
                .Include(e => e.Project)
                .ThenInclude(e => e.AffiliatedUnit)
                .Include(e => e.Project)
                .ThenInclude(e => e.Participations)
                .Where(e => e.UserId == user.UserId);
            return part;
        }

        public override void GoToIndex()
        {
            SetChildren(new ProjectIndexFriendlyUI(this, RowsParticipation()));
            ChangeLabel("index");
        }
    }
}
