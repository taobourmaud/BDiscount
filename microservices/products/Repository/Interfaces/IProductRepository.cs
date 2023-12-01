using products.Models;

namespace products.Repository.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllProducts();
    
    Task<Product>? GetProductByIdAsync(int productId);

    Task AddProductAsync(Product product);
    
    Task<Product> UpdateProductAsync(int productId, Product updatedProduct);
    
    Task DeleteProductAsync(int productId);
}
