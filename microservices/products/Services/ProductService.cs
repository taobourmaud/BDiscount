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
        try
        {
            return await _productRepository.GetAllProducts();
        }
        catch (Exception ex)
        {
            
            throw new Exception($"Une erreur s'est produite lors de la récupération de tous les produits. ", ex);
        }
    }

    public async Task<Product> GetProductById(int productId)
    {
        try
        {
            return await _productRepository.GetProductByIdAsync(productId)!;
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la récupération du produit {productId}. ", ex);
        }
    }

    public async Task AddProductAsync(Product product)
    {
        try
        {
            await _productRepository.AddProductAsync(product);
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la création du produit.", ex);
        }
    }
    
    public async Task<Product> UpdateProductAsync(int productId, Product product)
    {
        try
        {
            return await _productRepository.UpdateProductAsync(productId, product);
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la modification du produit.", ex);
        }
    }
    
    
    public async Task DeleteProductAsync(int productId)
    {
        try
        {
            await _productRepository.DeleteProductAsync(productId);
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la supression du produit.", ex);
        }
    }

}