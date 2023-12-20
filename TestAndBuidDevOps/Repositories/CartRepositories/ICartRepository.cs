using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.CartRepositories;

public interface ICartRepository : IRepositoryAsync<CartItemEntity>
{
}