using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IPM_winform.IPM.Infrastructure.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        // builder.HasMany(e => e.Users)
        //     .WithMany(e => e.Projects)
        //     .UsingEntity<Participation>(
        //             l => l.HasOne<User>().WithMany().HasForeignKey(e => e.UserId),
        //             r => r.HasOne<Project>().WithMany().HasForeignKey(e => e.ProjectId)
        //     );
    }
}
