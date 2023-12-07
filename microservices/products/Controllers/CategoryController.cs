using Microsoft.AspNetCore.Mvc;
using products.Models;
using products.Services.Interfaces;

namespace products.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _categoryService.GetAllCategories();
        return Ok(categories);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] Category category)
    {
        try
        {
            if (category == null)
            {
                return BadRequest("Product data is null");
            }
            
            await _categoryService.AddCategoryAsync(category);
            /*
            return CreatedAtAction(nameof(GetProductById), new { productId = product.Id }, product);
            */

            return Ok(category);

        }
        catch (Exception e)
        {
            // Handle the exception, for example, log the error.
            return StatusCode(500, "Internal server error");
        }
    }
    
}