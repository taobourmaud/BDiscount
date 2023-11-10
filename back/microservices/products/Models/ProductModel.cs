namespace products.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal price { get; set; }
    public string Image { get; set; }
    public string Category { get; set; }
}