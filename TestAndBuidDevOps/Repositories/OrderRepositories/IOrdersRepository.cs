using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.OrderRepositories;

public interface IOrdersRepository : IRepositoryAsync<OrderEntity>
{
}