using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class AllMotherboardCategories : IMotherboardsCategory
    {
        public IEnumerable<MotherboardCategory> AllMotherboardsCategories
        {
            get
            {
                return new List<MotherboardCategory>
                {
                    new MotherboardCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                    new MotherboardCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                };
            }
        }
    }
}
