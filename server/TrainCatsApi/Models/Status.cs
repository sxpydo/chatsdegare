public class Status
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public ICollection<Report>? Report { get; set; }
}