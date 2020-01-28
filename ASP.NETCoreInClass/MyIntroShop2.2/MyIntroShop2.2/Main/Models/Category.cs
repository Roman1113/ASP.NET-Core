using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Phone> phones { set; get; }
    }
}
