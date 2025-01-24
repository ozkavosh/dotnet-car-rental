using System.ComponentModel.DataAnnotations;

namespace Bigger.CrudCars.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public BaseEntity() {
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}
