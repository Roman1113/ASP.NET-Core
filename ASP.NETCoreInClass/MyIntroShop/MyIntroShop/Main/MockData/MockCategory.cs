using MyIntroShop.Main.Interfaces;
using MyIntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop.Main.MockData
{
    public class MockCategory : IVideoCardsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Games", categoryDescription = "Video card for games"},
                    new Category {categoryName = "Disigner", categoryDescription = "Video card for 3d"}
                };
            }
        }
    }
}
