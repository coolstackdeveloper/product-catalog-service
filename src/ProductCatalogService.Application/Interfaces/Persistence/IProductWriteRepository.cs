using System;
using System.Threading.Tasks;
using ProductCatalogService.Domain.Models;

namespace ProductCatalogService.Application.Interfaces.Persistence
{
    public interface IProductWriteRepository
    {
        Task CreateProduct(Product product);
        Task UpdateProduct(Guid productId, string name, string description, decimal? price, decimal? deliveryPrice);
        Task DeleteProduct(Guid productId);
        Task CreateProductOption(ProductOption productOption);
        Task UpdateProductOption(Guid productOptionId, string name, string description);
        Task DeleteProductOption(Guid productOptionId);
    }
}