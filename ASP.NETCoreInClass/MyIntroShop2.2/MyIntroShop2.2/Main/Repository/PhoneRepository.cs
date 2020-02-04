using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class PhoneRepository : IAllPhones
    {
        private readonly DBContent dbContent;
        public PhoneRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Phone> phones => dbContent.Phone.Include(c => c.PhoneCategory);
    }
}
