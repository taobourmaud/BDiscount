using products.Models;

namespace products.Services.Interfaces;

public interface ICategoryService
{
    public Task<List<Category>> GetAllCategories();

    public Task AddCategoryAsync(Category category);
}