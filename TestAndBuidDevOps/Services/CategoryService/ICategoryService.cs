using Domain.Dtos;
using Domain.Entities;

namespace TestAndBuidDevOps.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<CategoryEntity>> GetCategories();
        Task<List<CategoryEntity>> GetAdminCategories();
        Task<List<CategoryEntity>> AddCategory(CategoryEntity category);
        Task<List<CategoryEntity>> UpdateCategory(CategoryEntity category);
        Task<List<CategoryEntity>> DeleteCategory(Guid id);
    }
}
