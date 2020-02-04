using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class ProcesorCategoryRepository : IProcesorCategory
    {
        private readonly DBContent dbContent;
        public ProcesorCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<ProcesorCategory> AllProcesorsCategories => dbContent.ProcesorCategories;
    }
}
