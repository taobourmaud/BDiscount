using baskets.Models;
using baskets.Repository.Interfaces;
using baskets.Services.Interfaces;

namespace baskets.Services;

public class BasketService : IBasketService
{

    private readonly IBasketRepository _basketRepository;

    public BasketService(IBasketRepository basketRepository)
    {
        _basketRepository = basketRepository ?? throw new ArgumentNullException(nameof(basketRepository));;
    }
    
    public async Task AddBasketAsync(Basket basket)
    {
        try
        {
            await _basketRepository.AddBasketAsync(basket);
        }
        catch (Exception ex)
        {
            throw new Exception($"Une erreur s'est produite lors de la création du produit.", ex);
        }
    }

    public async Task<List<Basket>> GetBasketByUserId(int userId)
    {
        try
        {
            return await _basketRepository.GetBasketByUserId(userId);
        }
        catch (Exception e)
        {
            throw new Exception($"Une erreur s'est produite lors récupération du panier de l'utilisateur.", e);
        }
    }

    public async Task<Basket> UpdateBasketAsync(int basketId, Basket basket)
    {
        try
        {
            return await _basketRepository.UpdateBasketAsync(basketId, basket);
        }
        catch (Exception e)
        {
            throw new Exception($"Une erreur s'est produite lors de la mise à jour du produit dans le panier.", e);
        }
    }

    public async Task DeleteBasketAsync(int basketId)
    {
        try
        {
            await _basketRepository.DeleteBasketAsync(basketId);
        }
        catch (Exception e)
        {
            throw new Exception($"Une erreur s'est produite lors de la suppression du produit.", e);
        }
    }

    public async Task<Basket> GetBasketByIdAsync(int basketId)
    {
        try
        {
            return await _basketRepository.GetBasketByIdAsync(basketId);
        }
        catch (Exception e)
        {
            throw new Exception($"Une erreur s'est produite lors de la récupération du panier {basketId}. ", e);
        }
    }
}