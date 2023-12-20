using TestAndBuidDevOps.Data;
using Domain.Entities;

using EF.Support.RepositoryAsync;

namespace TestAndBuidDevOps.Repositories.OrderRepositories;

public class OrdersRepository : RepositoryAsync<OrderEntity>, IOrdersRepository
{
    private readonly ApplicationDbContext _context;

    public OrdersRepository(ApplicationDbContext context) : base(context, context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
}