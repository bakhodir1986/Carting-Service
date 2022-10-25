using Microsoft.Extensions.Options;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System;

namespace Carting_Service.DAL
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

//        Id – required, id of the item in external system(see Task 2), int.
//Name – required, plain text.
//Image – optional, URL and alt text.
//Price – required, money.
//Quantity – quantity of items in the cart.
    }
}
