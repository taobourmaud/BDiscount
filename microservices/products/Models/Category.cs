using products.Models.Interfaces;

namespace products.Models;

public class Category : ICategory
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    
    public virtual ICollection<Product>? Products { get; set; }
}