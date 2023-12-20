using Domain.Dtos;
using Domain.Entities;

namespace TestAndBuidDevOps.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ProductEntity>> GetProductsAsync();
        Task<ProductEntity> GetProductAsync(Guid productId);
        Task<List<ProductEntity>> GetProductsByCategory(string categoryUrl);
        Task<ProductSearchResult> SearchProducts(string searchText, int page);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
        Task<List<ProductEntity>> GetFeaturedProducts();
        Task<List<ProductEntity>> GetAdminProducts();
        Task<ProductEntity> CreateProduct(ProductEntity product);
        Task<ProductEntity> UpdateProduct(ProductEntity product);
        Task<bool> DeleteProduct(Guid productId);

    }
}
