using products.Models;

namespace products.Repository.Interfaces;


public interface IProductRepository
{
     Task<List<Product>> GetAllProducts();
    
    Task<Product>? GetProductByIdAsync(int productId);

    Task AddProductAsync(Product product);
    
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int productId);
}