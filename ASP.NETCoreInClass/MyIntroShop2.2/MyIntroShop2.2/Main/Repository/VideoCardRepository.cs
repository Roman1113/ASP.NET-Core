using Microsoft.EntityFrameworkCore;
using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Repository
{
    public class VideoCardRepository : IAllVideoCards
    {
        private readonly DBContent dbContent;
        public VideoCardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<VideoCard> videoCards => dbContent.VideoCards.Include(c => c.VideoCardCategory);
    }
}
