using products.Models;
using products.Repository.Interfaces;
using products.Services.Interfaces;

namespace products.Services;

public class CategoryService : ICategoryService
{
    
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));;
    }
    
    public async Task<List<Category>> GetAllCategories()
    {
        try
        {
            return await _categoryRepository.GetAllCategories();
        }
        catch (Exception ex)
        {
            
            throw new Exception($"Une erreur s'est produite lors de la récupération de tous les produits. ", ex);
        }
    }

    public async Task AddCategoryAsync(Category category)
    {
        try
        {
            await _categoryRepository.AddCategoryAsync(category);
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la création du produit.", ex);
        }
    }
}