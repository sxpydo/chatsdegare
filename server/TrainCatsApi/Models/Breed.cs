public class Breed
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Origin { get; set; }
    public string? Description { get; set; }
    public ICollection<Cat>? Cat { get; set; }
}