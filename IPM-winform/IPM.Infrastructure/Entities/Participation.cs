namespace IPM_winform.IPM.Infrastructure.Entities;

public class Participation : BaseEntity
{
    public int ProjectId { get; set; }
    public required string UserId { get; set; }
    public DateTime JoinDate { get; set; }
    public string? Status { get; set; }
    public string? Note { get; set; }
    public bool Owner { get; set; }

    public User? User { get; set; }
    public Project? Project { get; set; }

}

