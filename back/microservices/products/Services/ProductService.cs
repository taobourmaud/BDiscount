using products.Models;
using products.Repository.Interfaces;
using products.Services.Interfaces;

namespace products.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

   public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));;
    }
    public async Task<List<Product>> GetProducts()
    { 
        return await _productRepository.GetAllProducts();
    }
}