public class Location
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Address { get; set; }
    public string City { get; set; } = "";
    public string? State { get; set; }
    public int CountryId { get; set; }
    public string? PostalCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    // Navigation property
    public Country Country { get; set; } = null!;
}