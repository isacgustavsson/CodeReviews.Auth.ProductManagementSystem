namespace UI.Models.ViewModels;

public class ProductViewModel
{
    public int Id { get; }
    public required string? Name { get; set; }
    public decimal Price { get; set; }
}