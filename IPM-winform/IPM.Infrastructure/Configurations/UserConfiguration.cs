using IPM_winform.IPM.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IPM_winform.IPM.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasData(new User()
        {
            UserId = 1,
            Email = "admin@gmail.com",
            Password = "$2a$11$8xfjLfbXdKX9wr2jv23FNuHYPkRUV6VOmQFl/3/dlgGUtpl.zMw.2",
            Role = "Admin"
        });
        //builder.HasMany(e => e.Claims).WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

        //builder.HasMany(e => e.Logins).WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

        //builder.HasMany(e => e.Tokens).WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

        //// Each User can have many entries in the UserRole join table
        //builder
        //    .HasMany(e => e.UserRoles)
        //    .WithOne(e => e.User)
        //    .HasForeignKey(ur => ur.UserId)
        //    .IsRequired();
    }
}
