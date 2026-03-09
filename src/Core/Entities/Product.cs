namespace Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = false;
}
