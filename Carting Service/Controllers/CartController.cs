using Carting_Service.BLL;
using Microsoft.AspNetCore.Mvc;

namespace Carting_Service.Controllers
{
    public class CartController
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet(Name = "GetAllCarts")]
        public IEnumerable<Cart> Get()
        {
            return cartService.GetCarts();
        }

        [HttpPost(Name = "AddCart")]
        [ValidateAntiForgeryToken]
        public Guid Add()
        {
            return cartService.AddCart();
        }

        [HttpPost(Name = "AddCartItem")]
        [ValidateAntiForgeryToken]
        public void Add(Guid cartId, CartItem cartItem)
        {
            cartService.AddCartItem(cartId, cartItem);
        }

        [HttpDelete(Name = "RemoveCart")]
        public void Remove(string id)
        {
            cartService.DeleteCart(new Guid(id));
        }

        [HttpDelete(Name = "RemoveCartItem")]
        public void Remove(Guid cartId, int CartItemId)
        {
            cartService.DeleteCartItem(cartId, CartItemId);
        }
    }
}
