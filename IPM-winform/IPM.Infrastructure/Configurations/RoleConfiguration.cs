using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IPM_winform.IPM.Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {

        builder.HasData(
            new Role()
            {
                RoleId = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
            },
            new Role()
            {
                RoleId = 2,
                Name = "Manager",
                NormalizedName = "MANAGER",
            },
            new Role()
            {
                RoleId = 3,
                Name = "User",
                NormalizedName = "USER",
            }
        );
    }
}
