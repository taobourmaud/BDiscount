using baskets.Models;

namespace baskets.Services.Interfaces;

public interface IBasketService
{
    public Task AddBasketAsync(Basket basket);
    
    public Task<List<Basket>> GetBasketByUserId(int userId);

    public Task<Basket> UpdateBasketAsync(int basketId, Basket basket);

    public Task DeleteBasketAsync(int basketId);

    public Task<Basket> GetBasketByIdAsync(int basketId);
}