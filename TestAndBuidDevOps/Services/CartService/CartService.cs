﻿using TestAndBuidDevOps.Repositories.CartRepositories;
using TestAndBuidDevOps.Repositories.ProductRepositories;
using Domain.Dtos;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System.Security.Claims;

namespace TestAndBuidDevOps.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private Guid userId;

        public CartService(ICartRepository cartRepository, IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _httpContextAccessor = httpContextAccessor;
            userId = Guid.Parse(_httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
        }

        public async Task<List<CartProductDto>> GetCartProducts(List<CartItemEntity> cartItems)
        {
            var result = new List<CartProductDto>();

            foreach (var item in cartItems)
            {
                var product = await _productRepository.AsQueryable()
                    .Where(p => p.Id == item.ProductId)
                    .FirstOrDefaultAsync();

                if (product == null)
                {
                    continue;
                }


                var cartProduct = new CartProductDto
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    ImageUrl = product.Image,
                    Price = (product.NewPrice != null) ? product.NewPrice : product.OriginalPrice,
                    Quantity = item.Quantity
                };

                result.Add(cartProduct);
            }

            return result;
        }

        public async Task<List<CartProductDto>> StoreCartItems(List<CartItemEntity> cartItems)
        {
            var userId = Guid.Parse(_httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            cartItems.ForEach(cartItem => cartItem.UserId = userId);
            await _cartRepository.AddRangeAsync(cartItems);
            await _cartRepository.SaveChangesAsync();

            return await GetDbCartProducts();
        }

        public Task<int> GetCartItemsCount()
        {
            var userId = Guid.Parse(_httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var count = _cartRepository.AsQueryable().Where(ci => ci.UserId == userId).ToList().Count;
            return Task.FromResult(count);
        }

        public async Task<List<CartProductDto>> GetDbCartProducts()
        {

            return await GetCartProducts(_cartRepository.AsQueryable().Where(ci => ci.UserId == userId).ToList());
        }

        public async Task<bool> AddToCart(CartItemEntity cartItem)
        {
            cartItem.UserId = userId;

            var sameItem = await _cartRepository.AsQueryable()
                .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId && ci.UserId == cartItem.UserId);
            if (sameItem == null)
            {
                await _cartRepository.AddAsync(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
                await _cartRepository.UpdateAsync(sameItem);
            }

            await _cartRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateQuantity(CartItemEntity cartItem)
        {
            var dbCartItem = await _cartRepository.AsQueryable()
                .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId && ci.UserId == userId);
            if (dbCartItem == null)
            {
                return false;
            }

            dbCartItem.Quantity = cartItem.Quantity;
            await _cartRepository.UpdateAsync(dbCartItem);
            await _cartRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveItemFromCart(Guid productId)
        {
            var dbCartItem = await _cartRepository.AsQueryable()
                .FirstOrDefaultAsync(ci => ci.ProductId == productId && ci.UserId == userId);
            if (dbCartItem == null)
            {
                return false;
            }

            await _cartRepository.RemoveAsync(dbCartItem);
            await _cartRepository.SaveChangesAsync();

            return true;
        }
    }
}
