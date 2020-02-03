using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockSsdCategory : ISsdCategory
    {
        public IEnumerable<SsdCategory> AllSsdsCategories
        {
             get
             {
                return new List<SsdCategory>
                {
                    new SsdCategory {categoryName = "Flagman", categoryDescription = "Ssd with low path"},
                    new SsdCategory {categoryName = "Budget", categoryDescription = "Ssd with hight path"}
                };
             }
        }  
    }
}
