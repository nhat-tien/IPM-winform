namespace IPM_winform.IPM.Infrastructure.Entities;

public class ProjectUpdateLog
{
    public int ProjectUpdateLogId { get; set; }
    public int ProjectId { get; set; }
    public int UserId { get; set; }
    public DateTime UpdatedAt { get; set; }
}

