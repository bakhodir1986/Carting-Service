namespace Carting_Service.DAL
{
    public interface ICartRepository
    {
        void AddCart(Cart cart);
        IEnumerable<Cart> GetCarts();
        void RemoveCart(Guid cartId);
    }
}