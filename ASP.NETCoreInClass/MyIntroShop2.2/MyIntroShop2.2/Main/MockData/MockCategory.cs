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
        public IEnumerable<PhoneCategory> AllPhoneCategories
        {
             get
             {
                return new List<PhoneCategory>
                {
                    new PhoneCategory {categoryName = "Flagman", categoryDescription = "Phone with low path"},
                    new PhoneCategory {categoryName = "Budget", categoryDescription = "Phone with hight path"}
                };
             }
        }  
    }
}
