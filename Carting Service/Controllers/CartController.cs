using Carting_Service.BLL;
using Carting_Service.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Carting_Service.Controllers
{
    public class CartController
    {
        private readonly ICartManager cartManager;

        public CartController(ICartManager cartManager)
        {
            this.cartManager = cartManager;
        }

        [HttpGet(Name = "GetAllCarts")]
        public IEnumerable<Cart> Get()
        {
            return cartManager.GetCarts();
        }

        [HttpPost(Name = "AddCart")]
        [ValidateAntiForgeryToken]
        public void Add(Cart cart)
        {
            cartManager.AddCart(cart);
        }

        [HttpDelete(Name = "RemoveCart")]
        public void Remove(string id)
        {
            cartManager.RemoveCart(new Guid(id));
        }
    }
}
