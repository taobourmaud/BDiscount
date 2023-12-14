using baskets.Helpers;
using baskets.Models;
using baskets.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace baskets.Repository;

public class BasketRepository : IBasketRepository
{
    private readonly DataContext _dataContext;

    public BasketRepository(DataContext dataContext)
    {
        _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));;
    }
    
    public async Task AddBasketAsync(Basket basket)
    {
        try
        {
            _dataContext.Baskets.Add(basket);
            await _dataContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Une erreur s'est produite lors de l'ajout au panier.", ex);
        }
    }

    public async Task<List<Basket>> GetBasketByUserId(int userId)
    {
        try
        {
            List<Basket> baskets = await _dataContext.Baskets
                .Where(x => x.UserId == userId)
                .ToListAsync();

            return baskets;
        }
        catch (Exception e)
        {
            throw new Exception("Une erreur s'est produite lors de la récupération du panier.", e);
        }
    }

    public async Task<Basket> UpdateBasketAsync(int basketId, Basket basket)
    {
        try
        {
            var existingBasket = await _dataContext.Baskets.FindAsync(basketId);
            
            if (existingBasket == null)
            {
                throw new InvalidOperationException($"Le produit à l'Id {basketId} n'est pas trouvé.");
            }

            existingBasket.Quantity = basket.Quantity;
            
            _dataContext.Entry(existingBasket).State = EntityState.Modified;

            await _dataContext.SaveChangesAsync();

            return existingBasket;

        }
        catch (Exception e)
        {
            throw new Exception("Une erreur s'est produite durant la mise à jour du panier", e);
        }
    }

    public async Task DeleteBasketAsync(int basketId)
    {
        try
        {
            var basket = await _dataContext.Baskets.FindAsync(basketId);
            
            if (basket ==  null)
            {                
                throw new InvalidOperationException($"Le produit du panier à l'ID {basket?.Id} n'est pas trouvé.");
            }
            
            _dataContext.Baskets.Remove(basket);
            await _dataContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception("An error occurred while deleting the basket.", e);
        }
    }

    public async Task<Basket> GetBasketByIdAsync(int basketId)
    {
        try
{  
            return await _dataContext.Baskets.FindAsync(basketId) ?? throw new InvalidOperationException();

        }
        catch (Exception e)
        {
            throw new Exception($"Une erreur s'est produite lors de la récupération du produit dans le panier : {basketId}. ", e);
        }
    }
    
}