namespace Carting_Service.BLL
{
    public interface ICartRepository
    {
        void AddCart(Cart cart);
        IEnumerable<Cart> GetCarts();
        void RemoveCart(Guid cartId);

        Cart GetCart(Guid cartId);

        void UpdateCart(Cart cart);
    }
}