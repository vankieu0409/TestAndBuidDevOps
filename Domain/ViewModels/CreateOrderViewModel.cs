using Domain.Dtos;

namespace Domain.ViewModels;

public class CreateOrderViewModel
{
    public Guid UserId { get; set; }
    public List<CartProductDto> ProductCollection { get; set; }
}