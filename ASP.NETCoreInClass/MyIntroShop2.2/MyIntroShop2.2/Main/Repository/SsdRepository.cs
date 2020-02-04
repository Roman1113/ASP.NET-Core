using Microsoft.EntityFrameworkCore;
using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class SsdRepository : IAllSsd
    {
        private readonly DBContent dbContent;
        public SsdRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Ssd> ssds => dbContent.Ssds.Include(c => c.SsdCategory);
    }
}
