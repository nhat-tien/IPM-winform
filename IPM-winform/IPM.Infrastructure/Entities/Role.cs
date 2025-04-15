using Microsoft.AspNetCore.Identity;

namespace IPM_winform.IPM.Infrastructure.Entities;

public class Role : IdentityRole
{
    public virtual ICollection<UserRole>? UserRoles { get; set; }

}
