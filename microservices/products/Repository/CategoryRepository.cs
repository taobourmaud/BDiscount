using Microsoft.EntityFrameworkCore;
using products.Helpers;
using products.Models;
using products.Repository.Interfaces;

namespace products.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _dataContext;

    public CategoryRepository(DataContext dataContext)
    {
        _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));;
    }


    public async Task<List<Category>> GetAllCategories()
    {
        try
        {
            return await _dataContext.Categories.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite lors de la récupération de tous les produits.", ex);
        }
    }

    public async Task AddCategoryAsync(Category category)
    {
        try
        {
            _dataContext.Categories.Add(category);
            await _dataContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite lors de l'ajout du produit.", ex);
        }
    }
}