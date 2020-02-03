using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockProcesorCategory : IProcesorCategory
    {
        public IEnumerable<ProcesorCategory> AllProcesorsCategories
        {
             get
             {
                return new List<ProcesorCategory>
                {
                    new ProcesorCategory {categoryName = "Flagman", categoryDescription = "Procesor with low path"},
                    new ProcesorCategory {categoryName = "Budget", categoryDescription = "Procesor with hight path"}
                };
             }
        }  
    }
}
