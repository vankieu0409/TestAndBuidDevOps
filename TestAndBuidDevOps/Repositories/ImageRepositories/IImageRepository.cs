using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.ImageRepositories;

public interface IImageRepository : IRepositoryAsync<ImageEntity>
{
}