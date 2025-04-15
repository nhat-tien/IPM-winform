using Microsoft.AspNetCore.Identity;

namespace IPM_winform.IPM.Infrastructure.Entities;

//TODO: add more: Avatar
public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? PositionId { get; set; }
    public int? AffiliatedUnitId { get; set; }
    public Sex Sex { get; set; }
    public string? Address { get; set; }
    public string? AvatarUrl { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    //NOTE: I'm not sure about this property's type, maybe it's a string
    public int VerifiedCodeEmail { get; set; }
    public int VerifiedStatus { get; set; }
    public DateTime VerificationValidTime { get; set; }

    public Position? Position { get; set; }
    public AffiliatedUnit? AffiliatedUnit { get; set; }

    // public List<Project>? Projects { get; set; }
    public List<Participation>? Participations { get; set; }

    public virtual ICollection<IdentityUserClaim<string>>? Claims { get; set; }
    public virtual ICollection<IdentityUserLogin<string>>? Logins { get; set; }
    public virtual ICollection<IdentityUserToken<string>>? Tokens { get; set; }
    public virtual List<UserRole>? UserRoles { get; set; }
}

public enum Sex
{
    NOT_KNOWN = 0,
    MALE = 1,
    FEMALE = 2,
}
