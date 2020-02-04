using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {

            if (!content.PhoneCategories.Any())
            {
                content.PhoneCategories.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                   new Phone
                   {
                       name = "Samsung S10",
                       description = "Best phone by sumsung",
                       img = "https://i2.rozetka.ua/goods/11052630/samsung_galaxy_s10_plus_6_128_gb_black_sm_g975fzkdsek_images_11052630657.jpg",
                       price = 23000,
                       PhoneCategory = Categories["Flagman"]
                   },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone",
                        img = "https://static.turbosquid.com/Preview/001329/666/6L/_DHQ.jpg",
                        price = 700,
                        PhoneCategory = Categories["Budget"]
                    },
                    new Phone
                    {
                        name = "Lenovo z-5",
                        description = "Best phone by Lenovo",
                        img = "https://i.allo.ua/media/catalog/product/cache/1/image/425x295/799896e5c6c37e11608b9f8e1d047d15/f/i/file_613_3.jpg",
                        price = 3900,
                        PhoneCategory = Categories["Budget"]
                    },
                    new Phone
                    {
                        name = "Xiaomi Redmy 8",
                        description = "Best phone by Xiaomi",
                        img = "https://i8.rozetka.ua/goods/14142417/xiaomi_redmi_note_8_pro_6_128_black_images_14142417355.jpg",
                        price = 6999,
                        PhoneCategory = Categories["Flagman"]
                    }
                );
            }

            if (!content.MotherboardCategories.Any())
            {
                content.MotherboardCategories.AddRange(MotherboardCategories.Select(c => c.Value));
            }
            if (!content.Motherboards.Any())
            {
                content.AddRange(
                   new Motherboard
                   {
                       name = "Asus Prime B360-Plus",
                       description = "Материнська плата Asus Prime B360-Plus (s1151, Intel B360, PCI-Ex16)",
                       img = "https://i1.rozetka.ua/goods/10437607/asus_prime_b360_plus_images_10437607238.jpg",
                       price = 2619,
                       MotherboardCategory = MotherboardCategories["Budget"]
                   },
                    new Motherboard
                    {
                        name = "Материнська плата Asus ROG Strix X570-I Gaming",
                        description = "Материнська плата Asus ROG Strix X570-I Gaming (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i1.rozetka.ua/goods/14526857/asus_rog_strix_x570I_gaming_images_14526857356.jpg",
                        price = 7567,
                        MotherboardCategory = MotherboardCategories["Flagman"]
                    },
                    new Motherboard
                    {
                        name = "Материнська плата MSI MEG X570 Ace",
                        description = "Материнська плата MSI MEG X570 Ace (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i2.rozetka.ua/goods/12766274/msi_meg_x570_ace_images_12766274461.jpg",
                        price = 11215,
                        MotherboardCategory = MotherboardCategories["Flagman"]
                    },
                    new Motherboard
                    {
                        name = "Материнська плата Asus ROG Strix X570-F Gaming ",
                        description = "Материнська плата Asus ROG Strix X570-F Gaming (sAM4, AMD X570, PCI-Ex16)",
                        img = "https://i2.rozetka.ua/goods/12799704/asus_rog_strix_x570f_gaming_images_12799704289.jpg",
                        price = 8013,
                        MotherboardCategory = MotherboardCategories["Flagman"]
                    }
                );
            }

            if (!content.ProcesorCategories.Any())
            {
                content.ProcesorCategories.AddRange(ProcesorCategories.Select(c => c.Value));
            }
            if (!content.Procesors.Any())
            {
                content.AddRange(
                   new Procesor
                   {
                       name = "Процесор AMD Ryzen 5 3600 3.6 GHz",
                       description = "Процесор AMD Ryzen 5 3600 3.6 GHz / 32MB sAM4 BOX",
                       img = "https://i2.rozetka.ua/goods/12765144/amd_ryzen_5_3600_images_12765144943.jpg",
                       price = 5880,
                       ProcesorCategory = ProcesorCategories["Budget"]
                   },
                    new Procesor
                    {
                        name = "Процесор Intel Core i5-9400 2.9 GHz ",
                        description = "Процесор Intel Core i5-9400 2.9 GHz / 8GT / s / 9MB (BX80684I59400) s1151 BOX",
                        img = "https://i2.rozetka.ua/goods/13118701/intel_core_i5_9400_bx80684i59400_images_13118701380.jpg",
                        price = 5835,
                        ProcesorCategory = ProcesorCategories["Budget"]
                    },
                    new Procesor
                    {
                        name = "Процесор Intel Core i9-9900 3.1GHz",
                        description = "Процесор Intel Core i9-9900 3.1GHz / 8GT / s / 16MB (BX80684I99900) s1151 BOX",
                        img = "https://i2.rozetka.ua/goods/13345472/intel_core_i9_9900_bx80684i99900_images_13345472200.jpg",
                        price = 13750,
                        ProcesorCategory = ProcesorCategories["Flagman"]
                    },
                    new Procesor
                    {
                        name = "HP Intel Xeon E5",
                        description = "HP Intel Xeon E5-2609v3 DL160 Gen9 Kit (733943-B21)",
                        img = "https://i1.rozetka.ua/goods/2020325/hp_733943_b21_images_2020325947.jpg",
                        price = 14999,
                        ProcesorCategory = ProcesorCategories["Flagman"]
                    }
                );
            }

            content.SaveChanges();
        }


        private static Dictionary<string, MotherboardCategory> motherboardcategory;
        public static Dictionary<string, MotherboardCategory> MotherboardCategories
        {
            get
            {
                if (motherboardcategory == null)
                {
                    var list = new MotherboardCategory[]
                    {
                        new MotherboardCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                    new MotherboardCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                    };
                    motherboardcategory = new Dictionary<string, MotherboardCategory>();
                    foreach (MotherboardCategory item in list)
                    {
                        motherboardcategory.Add(item.categoryName, item);
                    }
                }
                return motherboardcategory;
            }
        }

        private static Dictionary<string, ProcesorCategory> procesorcategory;
        public static Dictionary<string, ProcesorCategory> ProcesorCategories
        {
            get
            {
                if (motherboardcategory == null)
                {
                    var list = new ProcesorCategory[]
                    {
                        new ProcesorCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                        new ProcesorCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                    };
                    procesorcategory = new Dictionary<string, ProcesorCategory>();
                    foreach (ProcesorCategory item in list)
                    {
                        procesorcategory.Add(item.categoryName, item);
                    }
                }
                return procesorcategory;
            }
        }

        private static Dictionary<string, PhoneCategory> category;
        public static Dictionary<string, PhoneCategory> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new PhoneCategory[]
                    {
                        new PhoneCategory { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                        new PhoneCategory { categoryName = "Budget", categoryDescription = "Phone with low price without extra fubctions" }
                    };
                    category = new Dictionary<string, PhoneCategory>();
                    foreach (PhoneCategory item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }

        }
    }
}
