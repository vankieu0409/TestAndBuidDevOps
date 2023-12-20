using TestAndBuidDevOps.Data;
using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.CartRepositories;

public class CartRepository : RepositoryAsync<CartItemEntity>, ICartRepository
{
    private readonly ApplicationDbContext _context;

    public CartRepository(ApplicationDbContext context) : base(context, context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
}