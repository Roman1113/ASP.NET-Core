using FirstProjectASP.NET.Core.Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { set; get; }
        public Car car { set; get; }
        public int price { set; get; }

        public string ShopCartId { get; set; }
    }
}
