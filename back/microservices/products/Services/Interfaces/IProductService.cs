
using products.Models;

namespace products.Services.Interfaces;

public interface IProductService
{
    public Task<List<Product>> GetProducts();
}