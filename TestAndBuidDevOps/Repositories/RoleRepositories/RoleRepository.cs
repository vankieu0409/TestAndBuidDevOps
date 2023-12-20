using TestAndBuidDevOps.Data;

using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.RoleRepositories;

public class RoleRepository : RepositoryAsync<RoleEntity>, IRoleRepository
{
    private readonly ApplicationDbContext _context;

    public RoleRepository(ApplicationDbContext context) : base(context, context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
}