using products.Models;

namespace products.Repository.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllCategories();

    Task AddCategoryAsync(Category category);

    // Task<Category>? GetProductByIdAsync(int productId);
    //
    // Task AddProductAsync(Category product);
    //
    // Task<Category> UpdateProductAsync(int productId, Category updatedProduct);
    //
    // Task DeleteProductAsync(int productId);
}