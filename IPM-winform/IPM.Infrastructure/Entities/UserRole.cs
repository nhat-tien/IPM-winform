using Microsoft.AspNetCore.Identity;

namespace IPM_winform.IPM.Infrastructure.Entities;

public class UserRole : IdentityUserRole<string>
{
    public virtual User? User { get; set; }
    public virtual Role? Role { get; set; }
}
