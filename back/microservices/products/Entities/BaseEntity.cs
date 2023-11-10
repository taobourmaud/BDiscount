
using System.ComponentModel.DataAnnotations.Schema;

namespace back.microservices.products.Entities
{
    public abstract class BaseEntity
    {
        [Column(name: "created_at")]
        public DateTime CreatedAt { get; set; }

        [Column(name: "updated_at")]
        public DateTime UpdatedAt { get; set; }

        public BaseEntity(
            DateTime createdAt, DateTime updatedAt
        ) => (CreatedAt, UpdatedAt) = (createdAt, updatedAt);
    }

}