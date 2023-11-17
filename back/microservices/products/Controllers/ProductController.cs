using Microsoft.AspNetCore.Mvc;
using products.Models;
using products.Services.Interfaces;

namespace products.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        List<Product> products = await _productService.GetProducts();
        return Ok(products);
    }
}