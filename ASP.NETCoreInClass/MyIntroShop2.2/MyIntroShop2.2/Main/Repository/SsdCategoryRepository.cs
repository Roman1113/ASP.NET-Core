using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class SsdCategoryRepository : ISsdCategory
    {
        private readonly DBContent dbContent;
        public SsdCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<SsdCategory> AllSsdsCategories => dbContent.SsdCategories;
    }
}
