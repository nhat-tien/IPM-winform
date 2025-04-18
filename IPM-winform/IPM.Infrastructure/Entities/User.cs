namespace IPM_winform.IPM.Infrastructure.Entities;

//TODO: add more: Avatar
public class User
{
    public int UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int? PositionId { get; set; }
    public int? AffiliatedUnitId { get; set; }
    public required string Password { get; set; }
    public required string Role { get; set; }
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

    
}

public enum Sex
{
    NOT_KNOWN = 0,
    MALE = 1,
    FEMALE = 2,
}
