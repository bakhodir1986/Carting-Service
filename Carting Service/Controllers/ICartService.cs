using Carting_Service.BLL;

namespace Carting_Service.Controllers
{
    public interface ICartService
    {
        IEnumerable<Cart> GetCarts();
        Guid AddCart();
        void AddCartItem(Guid cartId, CartItem cartItem);
        void DeleteCart(Guid cartId);

        void DeleteCartItem(Guid cartId, int CartItemId);
    }
}