using back.microservices.products.Entities;
using Microsoft.EntityFrameworkCore;
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
        return await _dataContext.Products.ToListAsync();
    }

}