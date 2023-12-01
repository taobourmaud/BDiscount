using Microsoft.EntityFrameworkCore;
using products.Helpers;
using products.Models;
using products.Repository.Interfaces;

namespace products.Repository;

public class ProductRepository : IProductRepository
{
     private readonly DataContext _dataContext;

    public ProductRepository(DataContext dataContext)
    {
        _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));;
    }

    public async Task<List<Product>> GetAllProducts()
    {
        try
        {
            return await _dataContext.Products.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite lors de la récupération de tous les produits.", ex);
        }
        
    }

    public async Task<Product> GetProductByIdAsync(int productId)
    {
        try
        {
            return await _dataContext.Products.FindAsync(productId);
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
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite lors de l'ajout du produit.", ex);
        }
    }

    

    public async Task<Product> UpdateProductAsync(int productId, Product updatedProduct)
    {
        try
        {
            var existingProduct = await _dataContext.Products.FindAsync(productId);

            if (existingProduct == null)
            {
                throw new InvalidOperationException($"Le produit à l'Id {productId} n'est pas trouvé.");
            }

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Category = updatedProduct.Category;
            existingProduct.Image = updatedProduct.Image;

            _dataContext.Entry(existingProduct).State = EntityState.Modified;

            await _dataContext.SaveChangesAsync();

            return existingProduct;
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite durant la mise à jour du produit", ex);
        }
    }

    public async Task DeleteProductAsync(int productId)
    {
        try
        {
            var product = await _dataContext.Products.FindAsync(productId);

            if (product ==  null)
            {                
                throw new InvalidOperationException($"Le produit à l'ID {product?.Id} n'est pas trouvé.");
            }

            _dataContext.Products.Remove(product);
            await _dataContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while deleting the product.", ex);
        }
    }
}