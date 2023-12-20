using Domain.Entities;
using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.RefreshTokenRepositories;

public interface IRefreshTokenRepository : IRepositoryAsync<RefreshTokenEntity>
{
}