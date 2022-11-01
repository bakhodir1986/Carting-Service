using Carting_Service.Controllers;

namespace Carting_Service.BLL
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        public IEnumerable<Cart> GetCarts()
        {
            return cartRepository.GetCarts();
        }

        public Guid AddCart()
        {
            Cart cart = new Cart
            {
                Id = Guid.NewGuid()
            };

            cartRepository.AddCart(cart);

            return cart.Id;
        }

        public void AddCartItem(Guid cartId, CartItem cartItem)
        {
            var cart = cartRepository.GetCart(cartId);

            if (cart == null) throw new Exception("Cart not exists");

            cart.AddItem(cartItem);

            cartRepository.UpdateCart(cart);
        }

        public void DeleteCartItem(Guid cartId, int CartItemId)
        {
            var cart = cartRepository.GetCart(cartId);

            if (cart == null) throw new Exception("Cart not exists");

            cart.RemoveItem(CartItemId);

            cartRepository.UpdateCart(cart);
        }

        public void DeleteCart(Guid cartId)
        {
            var cart = cartRepository.GetCart(cartId);

            if (cart == null) throw new Exception("Cart not exists");

            cartRepository.RemoveCart(cart.Id);
        }
    }
}
