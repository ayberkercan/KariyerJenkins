using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
