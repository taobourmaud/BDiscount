using Microsoft.AspNetCore.Mvc;

namespace products.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProduct _product;

    public ProductController(IProduct product)
    {
        _product = product;
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var allProducts = _product.GetProducts();
        return Ok(allProducts);
    }
}