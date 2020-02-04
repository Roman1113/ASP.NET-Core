using Microsoft.EntityFrameworkCore;
using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class RamRepository : IAllRam
    {
        private readonly DBContent dbContent;
        public RamRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Ram> rams => dbContent.Rams.Include(c => c.RamCategory);
    }
}
