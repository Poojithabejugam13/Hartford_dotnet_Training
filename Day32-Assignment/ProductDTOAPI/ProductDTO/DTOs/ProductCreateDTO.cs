namespace ProductDTOAPI.DTOs
{
    public class ProductCreateDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
