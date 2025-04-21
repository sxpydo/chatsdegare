public class Country
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Iso3 { get; set; } = "";
    public ICollection<Location>? Locations { get; set; }
}