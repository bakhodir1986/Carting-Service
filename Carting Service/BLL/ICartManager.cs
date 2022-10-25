using Carting_Service.DAL;

namespace Carting_Service.BLL
{
    public interface ICartManager
    {
        void AddCart(Cart cart);
        IEnumerable<Cart> GetCarts();
        void RemoveCart(Guid Id);
    }
}