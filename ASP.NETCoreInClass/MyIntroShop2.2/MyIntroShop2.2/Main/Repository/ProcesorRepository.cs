using Microsoft.EntityFrameworkCore;
using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class ProcesorRepository : IAllProcesors
    {
        private readonly DBContent dbContent;
        public ProcesorRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Procesor> procesors => dbContent.Procesors.Include(c => c.ProcesorCategory);
    }
}
