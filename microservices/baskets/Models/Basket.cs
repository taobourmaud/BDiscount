using baskets.Models.Interfaces.Interfaces;

namespace baskets.Models;

public class Basket : IBasket
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    
    public int ProductId { get; set; }
    
    public int Quantity { get; set; }
}