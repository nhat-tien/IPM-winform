namespace IPM_winform.IPM.Infrastructure.Entities;

public class File : BaseEntity
{
    public int FileId { get; set; }
    public string? FileName { get; set; }
    public string? ObjectName { get; set; }
    public string? Status { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ProjectId { get; set; }
    public Project? Project { get; set; }
}
