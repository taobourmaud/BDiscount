using baskets.Models;
using baskets.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace baskets.Controllers;


[ApiController]
[Route("api/basket")]
public class BasketController : ControllerBase
{
    private readonly IBasketService _basketService;

    public BasketController(IBasketService basketService)
    {
        _basketService = basketService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateBasket([FromBody] Basket basket)
    {
        try
        {
            if (basket == null)
            {
                return BadRequest("Product data is null");
            }
            
            await _basketService.AddBasketAsync(basket);

            return Ok(basket);
        }
        catch (Exception e)
        {
            // Handle the exception, for example, log the error.
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetBasketByUserId(int userId)
    {
        try
        {
            var baskets = await _basketService.GetBasketByUserId(userId);

            return Ok(baskets);
        }
        catch (Exception e)
        {
            // Handle the exception, for example, log the error.
            throw new Exception("Le panier que vous cherchez n'éxiste pas");
        }
    }
    
    // TODO
    /*[HttpDelete("{basketId}")]
    public async Task<IActionResult> DeleteBasketAsync(int basketId)
    {
        try
        {
            var basket = _basketService.GetBasketByIdAsync(basketId);

            if (basket ==  null)
            {
                return NotFound(); // 404 si le produit n'est pas trouvé
            }
            
            await _basketService.DeleteBasketAsync(basketId);

            return Ok("Le produit à bien été supprimé du panier");
        }
        catch (Exception e){
            
            throw new Exception("Le produit que vous cherchez n'éxiste pas dans le panier");
        }
    }*/

    [HttpPut("{basketId}")]
    public async Task<IActionResult> UpdateBasketAsync(int basketId, Basket basket)
    {
        try
        {
            var updatedBasketResult =  await _basketService.UpdateBasketAsync(basketId, basket);

            if (updatedBasketResult == null) 
            {
                return NotFound(); // 404 si le produit n'est pas trouvé
            }

            return Ok(updatedBasketResult);

        }
        catch (Exception e)
        {
            throw new Exception("Le produit que vous cherchez n'éxiste pas", e);
        }
    }
    
}