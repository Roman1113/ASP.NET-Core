using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockSsd : IAllSsd
    {

        private readonly ISsdCategory _ssdCategory = new MockSsdCategory();
        public IEnumerable<Ssd> ssds
        {
            get
            {
                return new List<Ssd>
                {
                    new Ssd
                    {
                        name = "Kingston SSD HyperX Fury 3D 240GB",
                        description = "Kingston SSD HyperX Fury 3D 120GB 2.5 SATAIII TLC (KC–S44120–6F)",
                        img = "https://i1.rozetka.ua/goods/10623849/kingston_kc_s44120_6f_images_10623849938.jpg",
                        price = 779,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    },
                    new Ssd
                    {
                        name = "Crucial BX500 240GB",
                        description = "Crucial BX500 240GB 2.5 SATAIII 3D NAND TLC (CT240BX500SSD1)",
                        img = "https://i1.rozetka.ua/goods/8328832/copy_crucial_ct120bx500ssd1_5bd71f830845f_images_8328832192.jpg",
                        price = 1139,
                        SsdCategory = _ssdCategory.AllSsdsCategories.Last()
                    },
                    new Ssd
                    {
                        name = "Samsung Portable SSD T5 500GB",
                        description = "Samsung Portable SSD T5 500GB USB 3.1 Type-C V-NAND TLC (MU-PA500B/WW) External",
                        img = "https://i1.rozetka.ua/goods/2270514/samsung_mu_pa500b_ww_images_2270514360.jpg",
                        price = 2899,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    },
                    new Ssd
                    {
                        name = "Verbatim SSD Vi500 S3 240GB",
                        description = "Verbatim SSD Vi500 S3 240GB 2.5 SATAIII 3D NAND TLC (70023)",
                        img = "https://i1.rozetka.ua/goods/8279155/verbatim_70023_images_8279155294.jpg",
                        price = 999,
                        SsdCategory = _ssdCategory.AllSsdsCategories.First()
                    }
                };
            }
        }
    }
}
