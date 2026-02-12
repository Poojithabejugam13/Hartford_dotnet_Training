using ProductDTOAPI.Models;
using ProductDTOAPI.DTOs;
namespace ProductDTOAPI.Service
{
    public class ProductService : IProductService
        {
            private static List<Category> _categories = new()
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Furniture" },
        };

            private static List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000.00m, CategoryId = 1 },
            new Product { Id = 2, Name = "Desktop", Price = 2000.00m, CategoryId = 1 },
            new Product { Id = 3, Name = "Chair", Price = 150.00m, CategoryId = 2 },
        };

            public IEnumerable<ProductDTO> GetAllProducts()
            {
                return _products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = _categories
                        .FirstOrDefault(c => c.Id == p.CategoryId)?.Name ?? "Unknown"
                });
            }

            public ProductDTO? GetProductById(int id)
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                if (product == null) return null;

                return new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    CategoryName = _categories
                        .FirstOrDefault(c => c.Id == product.CategoryId)?.Name ?? "Unknown"
                };
            }
        public ProductDTO CreateProduct(ProductCreateDTO createDto)
        {
            var newProduct = new Product
            {
                Id = _products.Max(p => p.Id) + 1,
                Name = createDto.Name,
                Price = createDto.Price,
                CategoryId = createDto.CategoryId
            };
            _products.Add(newProduct);
            return new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price,
                CategoryName = _categories
                    .FirstOrDefault(c => c.Id == newProduct.CategoryId)?.Name ?? "Unknown"
            };
        }
            public bool UpdateProduct(int id, ProductUpdateDTO updateDto)
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                if (product == null) return false;

                product.Name = updateDto.Name;
                product.Price = updateDto.Price;
                product.CategoryId = updateDto.CategoryId;

                return true;
            }
            public bool DeleteProduct(int id)
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                if (product == null) return false;

                _products.Remove(product);
                return true;
            }
        }
    }
