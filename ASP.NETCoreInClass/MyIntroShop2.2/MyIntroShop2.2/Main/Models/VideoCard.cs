using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.Models
{
    public class VideoCard
    {
        public int Id { get; set; }
        public string name { set; get; }
        public string description { get; set; }
        public string img { set; get; }
        public uint price { set; get; }
        public virtual VideoCardCategory VideoCardCategory { set; get; }
    }
}
