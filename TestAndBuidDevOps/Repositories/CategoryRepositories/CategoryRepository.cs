using TestAndBuidDevOps.Data;
using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.CategoryRepositories;

public class CategoryRepository : RepositoryAsync<CategoryEntity>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context) : base(context, context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
}