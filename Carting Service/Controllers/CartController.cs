using Carting_Service.BLL;
using Carting_Service.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Carting_Service.Controllers
{
    public class CartController
    {
        [HttpGet(Name = "GetAllCarts")]
        public IEnumerable<Cart> Get()
        {
            return CartManager.GetCarts();
        }

        [HttpPost(Name = "AddCart")]
        [ValidateAntiForgeryToken]
        public void Add(Cart cart)
        {
            CartManager.AddCart(cart);
        }

        [HttpDelete(Name = "RemoveCart")]
        public void Remove(string id)
        {
            CartManager.RemoveCart(new Guid(id));
        }
    }
}
