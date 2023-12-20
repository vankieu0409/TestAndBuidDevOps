using TestAndBuidDevOps.Services.CartService;
using Domain.Dtos;
using Domain.Entities;

using Microsoft.AspNetCore.Mvc;

namespace TestAndBuidDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<List<CartProductDto>>> GetCartProducts(List<CartItemEntity> cartItems)
        {
            var result = await _cartService.GetCartProducts(cartItems);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<CartProductDto>>> StoreCartItems(List<CartItemEntity> cartItems)
        {
            var result = await _cartService.StoreCartItems(cartItems);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<ActionResult<bool>> AddToCart(CartItemEntity cartItem)
        {
            var result = await _cartService.AddToCart(cartItem);
            return Ok(result);
        }

        [HttpPut("update-quantity")]
        public async Task<ActionResult<bool>> UpdateQuantity(CartItemEntity cartItem)
        {
            var result = await _cartService.UpdateQuantity(cartItem);
            return Ok(result);
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult<bool>> RemoveItemFromCart(Guid productId)
        {
            var result = await _cartService.RemoveItemFromCart(productId);
            return Ok(result);
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetCartItemsCount()
        {
            return await _cartService.GetCartItemsCount();
        }

        [HttpGet]
        public async Task<ActionResult<List<CartProductDto>>> GetDbCartProducts()
        {
            var result = await _cartService.GetDbCartProducts();
            return Ok(result);
        }
    }
}
