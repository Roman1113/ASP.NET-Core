using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Interfaces
{
    public interface IRamCategory
    {
        IEnumerable<RamCategory> AllRamsCategories { get; }
    }
}
