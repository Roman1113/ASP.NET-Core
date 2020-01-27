using MyIntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop.Main.Interfaces
{
    interface IVideoCardsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
