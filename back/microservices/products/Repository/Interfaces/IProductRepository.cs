using products.Models;

namespace products.Repository.Interfaces;


public interface IProductRepository
{
    public Task<List<Product>> GetAllProducts();
}