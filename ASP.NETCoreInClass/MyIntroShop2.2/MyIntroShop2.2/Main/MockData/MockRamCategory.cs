using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockRamCategory : IRamCategory
    {
        public IEnumerable<RamCategory> AllRamsCategories
        {
             get
             {
                return new List<RamCategory>
                {
                    new RamCategory {categoryName = "Flagman", categoryDescription = "Phone with low path"},
                    new RamCategory {categoryName = "Budget", categoryDescription = "Phone with hight path"}
                };
             }
        }  
    }
}
