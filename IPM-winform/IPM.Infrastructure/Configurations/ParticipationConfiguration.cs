using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IPM_winform.IPM.Infrastructure.Configurations;

public class ParticipationConfiguration : IEntityTypeConfiguration<Participation>
{
    public void Configure(EntityTypeBuilder<Participation> builder)
    {
        builder.HasKey(l => new { l.ProjectId, l.UserId });
    }
}
