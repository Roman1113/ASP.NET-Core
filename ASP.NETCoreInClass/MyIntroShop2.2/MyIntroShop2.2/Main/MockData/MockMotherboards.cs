using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockMotherboards : IAllMotherboards
    {

        private readonly IMotherboardsCategory _motherboardsCategory = new MockMotherboardCategory();
     
        public IEnumerable<Motherboard> motherboards
        {
            get
            {
                return new List<Motherboard>
                {
                    new Motherboard
                    {
                        name = "Asus Prime B360-Plus",
                        description = "Материнська плата Asus Prime B360-Plus (s1151, Intel B360, PCI-Ex16)",
                        img = "https://i1.rozetka.ua/goods/10437607/asus_prime_b360_plus_images_10437607238.jpg",
                        price = 2619,
                        MotherboardCategory = _motherboardsCategory.AllMotherboardsCategories.First()
                    },
                    new Motherboard
                    {
                        name = "Материнська плата Asus ROG Strix X570-I Gaming",
                        description = "Материнська плата Asus ROG Strix X570-I Gaming (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i1.rozetka.ua/goods/14526857/asus_rog_strix_x570I_gaming_images_14526857356.jpg",
                        price = 7567,
                        MotherboardCategory = _motherboardsCategory.AllMotherboardsCategories.Last()
                    },
                    new Motherboard
                    {
                        name = "Материнська плата MSI MEG X570 Ace",
                        description = "Материнська плата MSI MEG X570 Ace (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i2.rozetka.ua/goods/12766274/msi_meg_x570_ace_images_12766274461.jpg",
                        price = 11215,
                        MotherboardCategory = _motherboardsCategory.AllMotherboardsCategories.First()
                    },
                    new Motherboard
                    {
                        name = "Материнська плата Asus ROG Strix X570-F Gaming ",
                        description = "Материнська плата Asus ROG Strix X570-F Gaming (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i2.rozetka.ua/goods/12799704/asus_rog_strix_x570f_gaming_images_12799704289.jpg",
                        price = 8013,
                        MotherboardCategory = _motherboardsCategory.AllMotherboardsCategories.First()
                    }
                };
            }
        }
    }
}
