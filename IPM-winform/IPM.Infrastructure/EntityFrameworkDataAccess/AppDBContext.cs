namespace IPM.Infrastructure.EntityFrameworkDataAccess;

using IPM_winform.IPM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using IPM_winform.IPM.Infrastructure.Entities;
using System.Configuration;

public class AppDBContext : DbContext
{
    public AppDBContext()
        : base() { }

    public DbSet<AffiliatedUnit> AffiliatedUnits { get; set; } = null!;
    //public DbSet<AidType> AidTypes { get; set; } = null!;
    public DbSet<ApprovingAgency> ApprovingAgencies { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Counterparty> Counterparties { get; set; } = null!;
    //public DbSet<CurrencyUnit> CurrencyUnits { get; set; } = null!;
    public DbSet<Participation> Participations { get; set; } = null!;
    public DbSet<Position> Positions { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } = null!;
    //public DbSet<ProjectUpdateLog> ProjectUpdateLogs { get; set; } = null!;
    //public DbSet<ReportedProject> ReportedProjects { get; set; } = null!;
    //public DbSet<Sponsor> Sponsors { get; set; } = null!;
    public DbSet<File> Files {get; set;} = null!;
    //public DbSet<FileType> FileTypes {get; set;} = null!;
    public DbSet<User> Users { get; set; } = null!;
    //public DbSet<Role> Roles { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["IPM"].ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();

            if (tableName != null && tableName.StartsWith("AspNet"))
            {
                entityType.SetTableName(tableName.Substring(6));
            }
        }
        builder.ApplyConfiguration(new UserConfiguration());
        //builder.ApplyConfiguration(new RoleConfiguration());
        builder.ApplyConfiguration(new ParticipationConfiguration());
        // builder.ApplyConfiguration(new ProjectConfiguration());
        // builder.HasDefaultSchema();
    }

    public override int SaveChanges()
    {
        DeleteFilesMarkedForDeletion();
        return base.SaveChanges();
    }

    private void DeleteFilesMarkedForDeletion()
    {
        var deletedEntities = ChangeTracker.Entries<File>()
            .Where(e => e.State == EntityState.Deleted)
            .ToList();

        foreach (var entityEntry in deletedEntities)
        {
            var fileUrl = entityEntry.Entity.ObjectName;
            if (!string.IsNullOrEmpty(fileUrl) && System.IO.File.Exists(fileUrl))
            {
                System.IO.File.Delete(fileUrl);
            }
        }
    }
}
