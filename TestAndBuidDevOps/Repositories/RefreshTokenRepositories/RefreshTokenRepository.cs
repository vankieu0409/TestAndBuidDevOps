using TestAndBuidDevOps.Data;
using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.RefreshTokenRepositories;

public class RefreshTokenRepository : RepositoryAsync<RefreshTokenEntity>, IRefreshTokenRepository
{
    private readonly ApplicationDbContext _context;

    public RefreshTokenRepository(ApplicationDbContext context) : base(context, context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
}