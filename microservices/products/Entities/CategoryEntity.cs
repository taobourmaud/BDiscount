using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace products.Entities;


[Table("categories")]
public class CategoryEntity : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(name: "category_id")]
    public int CategoryId { get; set; }
    
    [Column(name: "name")]
    public string? Name { get; set; }
    
    public virtual ICollection<ProductEntity> Products { get; set; }
    
    public CategoryEntity(DateTime createdAt, DateTime updatedAt) : base(createdAt, updatedAt){}
}