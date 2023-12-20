using Domain.Dtos;
using Domain.Entities;

namespace TestAndBuidDevOps.Services.CartService
{
    public interface ICartService
    {
        Task<List<CartProductDto>> GetCartProducts(List<CartItemEntity> cartItems);
        Task<List<CartProductDto>> StoreCartItems(List<CartItemEntity> cartItems);
        Task<int> GetCartItemsCount();
        Task<List<CartProductDto>> GetDbCartProducts();
        Task<bool> AddToCart(CartItemEntity cartItem);
        Task<bool> UpdateQuantity(CartItemEntity cartItem);
        Task<bool> RemoveItemFromCart(Guid productId);
    }
}
