using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.ProductRepositories;

public interface IProductRepository : IRepositoryAsync<ProductEntity>
{
}