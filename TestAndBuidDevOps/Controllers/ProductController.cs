using Domain.Dtos;
using Domain.Entities;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;

using TestAndBuidDevOps.Services.ProductService;

namespace TestAndBuidDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _env;

        public ProductController(IProductService productService, IWebHostEnvironment env)
        {
            _productService = productService;
            _env = env;
        }

        [HttpGet("admin")]
        public async Task<ActionResult<List<ProductEntity>>> GetAdminProducts(ODataQueryOptions<ProductEntity> queryOptions)
        {
            var result = await _productService.GetAdminProducts();
            var castedResult = queryOptions.ApplyTo(result.AsQueryable()).Cast<ProductEntity>();
            return Ok(castedResult);
        }

        [HttpPost("admin")]
        public async Task<ActionResult<ProductEntity>> CreateProduct(ProductEntity product)
        {
            var result = await _productService.CreateProduct(product);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ProductEntity>> UpdateProduct(ProductEntity product)
        {
            var result = await _productService.UpdateProduct(product);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProduct(Guid id)
        {
            var result = await _productService.DeleteProduct(id);
            return Ok(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<ProductEntity>>> GetProducts(ODataQueryOptions<ProductEntity> queryOptions)
        {
            var result = await _productService.GetProductsAsync();
            var castedResult = queryOptions.ApplyTo(result.AsQueryable()).Cast<ProductEntity>();
            return Ok(castedResult);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductEntity>> GetProduct(Guid productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<List<ProductEntity>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);
            return Ok(result);
        }

        [HttpGet("search/{searchText}/{page}")]
        public async Task<ActionResult<ProductSearchResult>> SearchProducts(string searchText, int page = 1)
        {
            var result = await _productService.SearchProducts(searchText, page);
            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchText}")]

        public async Task<ActionResult<List<ProductEntity>>> GetProductSearchSuggestions([FromODataUri] string searchText, ODataQueryOptions<string> queryOptions)
        {
            var result = await _productService.GetProductSearchSuggestions(searchText);
            var castedResult = queryOptions.ApplyTo(result.AsQueryable()).Cast<string>();
            return Ok(castedResult);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<List<ProductEntity>>> GetFeaturedProducts(ODataQueryOptions<ProductEntity> queryOptions)
        {
            var result = await _productService.GetFeaturedProducts();
            var castedResult = queryOptions.ApplyTo(result.AsQueryable()).Cast<ProductEntity>();
            return Ok(castedResult);
        }

        [HttpPost("upload")]
        public async Task<ActionResult<List<string>>> UploadAsync(List<IFormFile> files)
        {
            var strings = new List<string>();
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file.FileName);
                //var path = Path.GetTempFileName();
                var path = Path.Combine(_env.ContentRootPath, "Unitities\\Images\\", fileName.Replace(" ", ""));
                await using FileStream fs = new(path, FileMode.Create);
                await file.CopyToAsync(fs);
                var imagePath = $"\\Unitities\\Images\\{fileName}";
                strings.Add(path);
            }


            return Ok(strings);
        }
    }
}
