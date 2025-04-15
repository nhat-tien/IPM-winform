using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IPM_winform.IPM.Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

        builder.HasData(
            new Role()
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "ADMIN",
            },
            new Role()
            {
                Id = "2",
                Name = "Manager",
                NormalizedName = "MANAGER",
            },
            new Role()
            {
                Id = "3",
                Name = "User",
                NormalizedName = "USER",
            }
        );
    }
}
