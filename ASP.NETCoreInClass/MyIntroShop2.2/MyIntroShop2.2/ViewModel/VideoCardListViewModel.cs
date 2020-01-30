using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.ViewModel
{
    public class VideoCardListViewModel
    {
        public IEnumerable<VideoCard> allVideoCards { set; get; }
        public string currentCategory { set; get; }
    }
}
