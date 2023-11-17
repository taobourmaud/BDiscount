
using products.Models;

namespace products.Services.Interfaces;

public interface IProductService
{
    public Task<List<Product>> GetProducts();
    public Task<Product> GetProductById(int productId);

    public Task AddProductAsync(Product product);

    public Task UpdateProductAsync(Product product);

    public Task DeleteProductAsync(int productId);


}