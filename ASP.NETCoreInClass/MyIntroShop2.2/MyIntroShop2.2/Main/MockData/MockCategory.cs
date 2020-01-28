using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockCategory : IPhoneCategory
    {
        public IEnumerable<Category> AllCategories
        {
             get
             {
                return new List<Category>
                {
                    new Category {categoryName = "Flagman", categoryDescription = "Phone with low path"},
                    new Category {categoryName = "Budget", categoryDescription = "Phone with hight path"}
                };
             }
        }  
    }
}
