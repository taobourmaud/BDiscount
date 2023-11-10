using products.Models;

namespace products;

public interface IProduct
{
    public List<ProductModel> GetProducts();
}