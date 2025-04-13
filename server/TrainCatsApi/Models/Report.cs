public class Report
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime ReportCreatedDate { get; set; }
    public DateTime ReportFoundDate { get; set; }
    public string? ReportDescription { get; set; }
    public string? ReportImageUrl { get; set; }
    public int? StatusId { get; set; }

    public User User { get; set; }
    public Status Status { get; set; }
}