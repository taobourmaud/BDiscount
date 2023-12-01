using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baskets.Entites;


[Table("basket")]
public class BasketEntity  : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name: "basket_id")]
    public int BasketId { get; set; }
    
    [Column(name: "user_id")]
    public int UserId { get; set; }
    
    [Column(name: "product_id")]
    public int ProductId { get; set; }
    
    [Column(name: "quantity")]
    public int Quantity { get; set; }
    
    public BasketEntity(DateTime createdAt, DateTime updatedAt) : base(createdAt, updatedAt){}
}