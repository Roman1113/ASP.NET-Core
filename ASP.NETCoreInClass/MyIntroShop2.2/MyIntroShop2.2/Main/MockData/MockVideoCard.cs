using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockVideoCard : IAllVideoCards
    {

        private readonly IVideoCardCategory _videoCardCategory = new MockVideoCardCategory();
        public IEnumerable<VideoCard> videoCards
        {
            get
            {
                return new List<VideoCard>
                {
                    new VideoCard
                    {
                        name = "Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus 8GB",
                        description = "Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus 8GB GDDR6 (256bit) (15500) (Type-C, 3 x HDMI, 3 x Display Port) (GV-N208SAORUS-8GC)",
                        img = "https://i2.rozetka.ua/goods/12839402/gigabyte_gv_n208saorus_8gc_images_12839402154.jpg",
                        price = 22688,
                        VideoCardCategory = _videoCardCategory.AllVideoCardsCategories.First()
                    },
                    new VideoCard
                    {
                        name = "Sapphire PCI-Ex Radeon RX 550 Pulse 2GB",
                        description = "Sapphire PCI-Ex Radeon RX 550 Pulse 2GB GDDR5 (128bit) (1071/6000) (DVI, HDMI, DisplayPort) (11268-16-20G)",
                        img = "https://i1.rozetka.ua/goods/14291798/sapphire_11268_16_20g_images_14291798161.jpg",
                        price = 2222,
                        VideoCardCategory = _videoCardCategory.AllVideoCardsCategories.Last()
                    },
                    new VideoCard
                    {
                        name = "Asus PCI-Ex Radeon RX580 ROG Strix OC 8GB",
                        description = "Asus PCI-Ex Radeon RX580 ROG Strix OC 8GB GDDR5 (256bit) (1360/8000) (DVI, 2 x HDMI, 2 x DisplayPort) (ROG-STRIX-RX580-O8G-GAMING)",
                        img = "https://i2.rozetka.ua/goods/1966299/asus_rog_strix_rx580_o8g_gaming_images_1966299098.jpg",
                        price = 6179,
                        VideoCardCategory = _videoCardCategory.AllVideoCardsCategories.First()
                    },
                    new VideoCard
                    {
                        name = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix Advanced 11GB",
                        description = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix Advanced 11GB GDDR6 (352bit) (1350/14000) (2xHDMI, 2xDisplayPort, Type-C) (ROG-STRIX-RTX2080TI-A11G-GAMING)",
                        img = "https://i1.rozetka.ua/goods/10552781/asus_rog_strix_rtx2080ti_a11g_gaming_images_10552781588.jpg",
                        price = 37670,
                        VideoCardCategory = _videoCardCategory.AllVideoCardsCategories.First()
                    }
                };
            }
        }
    }
}
