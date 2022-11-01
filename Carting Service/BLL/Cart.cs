using Microsoft.Extensions.Options;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System;

namespace Carting_Service.BLL
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<CartItem>();
        }

        public Guid Id { get; set; }
        
        public List<CartItem> Items { get; set; }

        public void AddItem(CartItem cartItem)
        {
            Items.Add(cartItem);
        }

        public void RemoveItem(int itemId)
        {
            var cartItem = Items.Find(x => x.Id == itemId);

            if (cartItem != null)
            {
                Items.Remove(cartItem);
            }
        }

        public void UpdateItem(CartItem cartItem)
        {
            var Item = Items.Find(x => x.Id == cartItem.Id);

            if (Item != null)
            {
                Item.Name = cartItem.Name;
                Item.Image = cartItem.Image;
                Item.Price = cartItem.Price;
                Item.Quontity = cartItem.Quontity;
            }
        }
    }
}
