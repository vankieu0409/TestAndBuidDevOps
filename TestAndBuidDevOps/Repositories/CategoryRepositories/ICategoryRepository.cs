using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.CategoryRepositories;

public interface ICategoryRepository : IRepositoryAsync<CategoryEntity>
{
}