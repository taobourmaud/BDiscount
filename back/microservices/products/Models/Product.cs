using products.Models.Interfaces;

namespace products.Models;

public class Product : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? Image { get; set; }
    public string? Category { get; set; }
}