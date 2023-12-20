using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.UserRepositories;

public interface IUserRepository : IRepositoryAsync<UserEntity>
{
}