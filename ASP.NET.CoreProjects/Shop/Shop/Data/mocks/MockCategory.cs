using FirstProjectASP.NET.Core.Shop.Data.Interfaces;
using FirstProjectASP.NET.Core.Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectASP.NET.Core.Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories{
            get
            {
                return new List<Category>
                {
                    new Category {categoryname = "Електроавтомобілі", desc="Сучасні авто"},
                    new Category {categoryname = "Клаичні авто", desc="Авто з двигуном внутрішнього згорання"}
                };
            }
        }
    }
}
