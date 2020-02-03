using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockRam : IAllRam
    {

        private readonly IRamCategory _ramCategory = new MockRamCategory();
        public IEnumerable<Ram> rams
        {
            get
            {
                return new List<Ram>
                {
                    new Ram
                    {
                        name = "Оперативна пам'ять HyperX DDR4-2666",
                        description = "Оперативна пам'ять HyperX DDR4-2666 16384MB PC4-21300 (Kit of 2x8192) Fury Black (HX426C16FB3K2/16)",
                        img = "https://i1.rozetka.ua/goods/13589923/hyperx_hx426c16fb3k2_16_images_13589923273.jpg",
                        price = 2045,
                        RamCategory = _ramCategory.AllRamsCategories.First()
                    },
                    new Ram
                    {
                        name = "Оперативна пам'ять Kingston DDR3",
                        description = "Оперативна пам'ять Kingston DDR3-1333 4096MB PC3-10600 (KVR13N9S8/4)",
                        img = "https://i1.rozetka.ua/goods/6975/kingston_kvr13n9s8_4_images_6975524.jpg",
                        price = 565,
                        RamCategory = _ramCategory.AllRamsCategories.Last()
                    },
                    new Ram
                    {
                        name = "Оперативна пам'ять HyperX DDR4",
                        description = "Оперативна пам'ять HyperX DDR4-2666 8192MB PC4-21300 (Kit of 2x4096) Fury Black (HX426C16FB3K2/8)",
                        img = "https://i2.rozetka.ua/goods/13589923/hyperx_hx426c16fb3k2_8_images_13589923975.jpg",
                        price = 1432,
                        RamCategory = _ramCategory.AllRamsCategories.First()
                    },
                    new Ram
                    {
                        name = "Оперативна пам'ять Crucial DDR4",
                        description = "Оперативна пам'ять Crucial DDR4-3000 16384MB PC4-24000 (Kit of 2x8192) Ballistix Sport LT Red (BLS2K8G4D30AESEK)",
                        img = "https://i1.rozetka.ua/goods/13436152/copy_crucial_bls2k4g4d240fse_5d54f434827d2_images_13436152106.jpg",
                        price = 2099,
                        RamCategory = _ramCategory.AllRamsCategories.First()
                    }
                };
            }
        }
    }
}
