namespace EKSystemApp.Application.DTO.Products.List
{
    public class ProductListDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
