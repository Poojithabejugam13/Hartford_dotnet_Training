using ProductDTOAPI.DTOs;
namespace ProductDTOAPI.Service
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO? GetProductById(int id);
        ProductDTO CreateProduct(ProductCreateDTO createDto);
        bool UpdateProduct(int id, ProductUpdateDTO updateDto);
        bool DeleteProduct(int id);
    }
}
