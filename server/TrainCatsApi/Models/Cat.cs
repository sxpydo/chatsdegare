public class Cat
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string ImageUrl { get; set; } = ""; // Ensure not null
    public DateTime UploadDate { get; set; }
    public int? BreedId { get; set; }
    public int? ColourId { get; set; }

    // Navigation properties (for relationships)
    public Breed? Breed { get; set; }
    public Colour? Colour { get; set; }
}