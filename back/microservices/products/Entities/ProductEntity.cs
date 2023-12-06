using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.microservices.products.Entities;

[Table("products")]
public class ProductEntity : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name: "product_id")]
    public int ProductId { get; set; }

    [Column(name: "name")]
    public string? Name { get; set; }

    [Column(name: "description")]
    public string? Description { get; set; }

    [Column(name: "price")]
    public decimal Price { get; set; }

    [Column(name: "image")]
    public string? Image { get; set; }

    [Column(name: "category")]
    public string? Category { get; set; }

    public ProductEntity() : base(DateTime.Now, DateTime.Now) { }
}