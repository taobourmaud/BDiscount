using products.Models;

namespace products.Services;

public class ProductService : IProduct
{
    private readonly DataContext _dbContext;

    public ProductService(DataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<ProductModel> GetProducts()
    {
        return _dbContext.Products.ToList();
    }
}