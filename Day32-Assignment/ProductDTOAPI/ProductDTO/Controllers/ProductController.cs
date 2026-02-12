using Microsoft.AspNetCore.Mvc;
using ProductDTOAPI.DTOs;
using ProductDTOAPI.Service;
namespace ProductDTOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(_productService.GetAllProducts());
        }
        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
                return NotFound(new { Message = $"Product with ID {id} not found." });

            return Ok(product);
        }
        [HttpPost]
        public ActionResult<ProductDTO> PostProduct([FromBody] ProductCreateDTO createDto)
        {
            var createdProduct = _productService.CreateProduct(createDto);

            return CreatedAtAction(nameof(GetProduct),
                new { id = createdProduct.Id },
                createdProduct);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductUpdateDTO updateDto)
        {
            if (id != updateDto.Id)
                return BadRequest(new { Message = "ID mismatch between route and body." });

            if (!_productService.UpdateProduct(id, updateDto))
                return NotFound(new { Message = $"Product with ID {id} not found." });

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (!_productService.DeleteProduct(id))
                return NotFound(new { Message = $"Product with ID {id} not found." });

            return NoContent();
        }
    }
}
