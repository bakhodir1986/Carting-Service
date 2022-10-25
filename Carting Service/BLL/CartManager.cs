using Carting_Service.DAL;

namespace Carting_Service.BLL
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepository cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        public IEnumerable<Cart> GetCarts()
        {
            return cartRepository.GetCarts();
        }

        public void AddCart(Cart cart)
        {
            if (cart == null) throw new ArgumentNullException("Cart item is invalid");

            cart.Id = Guid.NewGuid();

            cartRepository.AddCart(cart);
        }

        public void RemoveCart(Guid Id)
        {
            cartRepository.RemoveCart(Id);
        }
    }
}
