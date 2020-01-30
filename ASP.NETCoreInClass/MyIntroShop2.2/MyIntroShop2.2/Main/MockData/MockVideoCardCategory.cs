using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockVideoCardCategory : IVideoCardCategory
    {
        public IEnumerable<VideoCardCategory> AllVideoCardsCategories
        {
             get
             {
                return new List<VideoCardCategory>
                {
                    new VideoCardCategory {categoryName = "Flagman", categoryDescription = "Phone with low path"},
                    new VideoCardCategory {categoryName = "Budget", categoryDescription = "Phone with hight path"}
                };
             }
        }  
    }
}
