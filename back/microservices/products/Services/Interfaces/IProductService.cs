
using products.Models;

namespace products.Services.Interfaces;

public interface IProductService
{
    public Task<List<Product>> GetProducts();
    public Task<Product> GetProductById(int productId);

    public Task AddProductAsync(Product product);

    public Task<Product>  UpdateProductAsync(int productId, Product product);

    public Task DeleteProductAsync(int productId);


}