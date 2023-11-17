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

    [HttpGet("{productId}")]
    public async Task<IActionResult> GetProductById(int productId)
    {
        try
        {
            Product product = await _productService.GetProductById(productId);

            if (product == null)
            {
                return NotFound(); // 404 si le produit n'est pas trouvé
            }
            
            return Ok(product);

        }
        catch (Exception e)
        {
            throw new Exception("Le produit que vous cherchez n'éxiste pas");
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
        try
        {
            if (product == null)
            {
                return BadRequest("Product data is null");
            }

            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProductById), new { productId = product.Id }, product);
        }
        catch (Exception e)
        {
            // Handle the exception, for example, log the error.
            return StatusCode(500, "Internal server error");
        }
    }
}