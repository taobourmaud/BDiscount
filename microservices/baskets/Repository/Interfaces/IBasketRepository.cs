using baskets.Models;

namespace baskets.Repository.Interfaces;

public interface IBasketRepository
{
    Task AddBasketAsync(Basket basket);

    Task<List<Basket>> GetBasketByUserId(int userId);

    Task<Basket> UpdateBasketAsync(int basketId, Basket basket);

    Task DeleteBasketAsync(int basketId);
    
    Task<Basket> GetBasketByIdAsync(int basket);

}