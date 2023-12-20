using Domain.Dtos;

namespace TestAndBuidDevOps.Services.OrderService
{
    public interface IOrderService
    {
        Task<bool> PlaceOrder(List<CartProductDto> products);
        Task<List<OrderOverviewDto>> GetOrders();
        Task<OrderDto> GetOrderDetails(Guid orderId);
    }
}
