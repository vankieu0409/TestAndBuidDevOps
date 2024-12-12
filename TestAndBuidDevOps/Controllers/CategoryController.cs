using Domain.Entities;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using TestAndBuidDevOps.Services.CategoryService;

namespace TestAndBuidDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryEntity>>> GetCategories()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }

        [HttpGet("admin"), Authorize(Roles = "ADMINISTRATOR,EMPLOYEE")]
        public async Task<ActionResult<List<CategoryEntity>>> GetAdminCategories()
        {
            var result = await _categoryService.GetAdminCategories();
            return Ok(result);
        }

        [HttpDelete("admin/{id}"), Authorize(Roles = "ADMINISTRATOR,EMPLOYEE")]
        public async Task<ActionResult<List<CategoryEntity>>> DeleteCategory(Guid id)
        {
            var result = await _categoryService.DeleteCategory(id);
            return Ok(result);
        }

        [HttpPost("admin"), Authorize(Roles = "ADMINISTRATOR,EMPLOYEE")]
        public async Task<ActionResult<List<CategoryEntity>>> AddCategory(CategoryEntity category)
        {
            var result = await _categoryService.AddCategory(category);
            return Ok(result);
        }

        [HttpPut("admin"), Authorize(Roles = "ADMINISTRATOR,EMPLOYEE")]
        public async Task<ActionResult<List<CategoryEntity>>> UpdateCategory(CategoryEntity category)
        {
            var result = await _categoryService.UpdateCategory(category);
            return Ok(result);
        }
    }
}
