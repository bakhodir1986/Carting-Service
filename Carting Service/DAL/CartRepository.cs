using LiteDB;
using System.Xml;

namespace Carting_Service.DAL
{
    public class CartRepository : ICartRepository
    {
        private readonly string _connectionString;

        public CartRepository()
        {
            _connectionString = "CartDb.db";
        }

        public IEnumerable<Cart> GetCarts()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var col = db.GetCollection<Cart>("carts");

                var results = col.Query();

                return results.ToEnumerable();
            }
        }

        public void AddCart(Cart cart)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var col = db.GetCollection<Cart>("carts");

                col.Insert(cart);
            }
        }

        public void RemoveCart(Guid cartId)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var col = db.GetCollection<Cart>("carts");

                col.Delete(cartId);
            }
        }
    }
}
