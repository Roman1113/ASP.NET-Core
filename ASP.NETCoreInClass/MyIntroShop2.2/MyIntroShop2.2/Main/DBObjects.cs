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

            if (!content.RamCategories.Any())
            {
                content.RamCategories.AddRange(RamCategories.Select(c => c.Value));
            }
            if (!content.Rams.Any())
            {
                content.AddRange(
                   new Ram
                   {
                       name = "Оперативна пам'ять HyperX DDR4-2666",
                       description = "Оперативна пам'ять HyperX DDR4-2666 16384MB PC4-21300 (Kit of 2x8192) Fury Black (HX426C16FB3K2/16)",
                       img = "https://i1.rozetka.ua/goods/13589923/hyperx_hx426c16fb3k2_16_images_13589923273.jpg",
                       price = 2045,
                       RamCategory = RamCategories["Flagman"]
                   },
                    new Ram
                    {
                        name = "Оперативна пам'ять Kingston DDR3",
                        description = "Оперативна пам'ять Kingston DDR3-1333 4096MB PC3-10600 (KVR13N9S8/4)",
                        img = "https://i1.rozetka.ua/goods/6975/kingston_kvr13n9s8_4_images_6975524.jpg",
                        price = 565,
                        RamCategory = RamCategories["Budget"]
                    },
                    new Ram
                    {
                        name = "Оперативна пам'ять HyperX DDR4",
                        description = "Оперативна пам'ять HyperX DDR4-2666 8192MB PC4-21300 (Kit of 2x4096) Fury Black (HX426C16FB3K2/8)",
                        img = "https://i2.rozetka.ua/goods/13589923/hyperx_hx426c16fb3k2_8_images_13589923975.jpg",
                        price = 1432,
                        RamCategory = RamCategories["Budget"]
                    },
                    new Ram
                    {
                        name = "Оперативна пам'ять Crucial DDR4",
                        description = "Оперативна пам'ять Crucial DDR4-3000 16384MB PC4-24000 (Kit of 2x8192) Ballistix Sport LT Red (BLS2K8G4D30AESEK)",
                        img = "https://i1.rozetka.ua/goods/13436152/copy_crucial_bls2k4g4d240fse_5d54f434827d2_images_13436152106.jpg",
                        price = 2099,
                        RamCategory = RamCategories["Flagman"]
                    }
                );
            }

            if (!content.SsdCategories.Any())
            {
                content.SsdCategories.AddRange(SsdCategories.Select(c => c.Value));
            }
            if (!content.Ssds.Any())
            {
                content.AddRange(
                    new Ssd
                    {
                        name = "Kingston SSD HyperX Fury 3D 240GB",
                        description = "Kingston SSD HyperX Fury 3D 120GB 2.5 SATAIII TLC (KC–S44120–6F)",
                        img = "https://i1.rozetka.ua/goods/10623849/kingston_kc_s44120_6f_images_10623849938.jpg",
                        price = 779,
                        SsdCategory = SsdCategories["Budget"]
                    },
                    new Ssd
                    {
                        name = "Crucial BX500 240GB",
                        description = "Crucial BX500 240GB 2.5 SATAIII 3D NAND TLC (CT240BX500SSD1)",
                        img = "https://i1.rozetka.ua/goods/8328832/copy_crucial_ct120bx500ssd1_5bd71f830845f_images_8328832192.jpg",
                        price = 1139,
                        SsdCategory = SsdCategories["Budget"]
                    },
                    new Ssd
                    {
                        name = "Samsung Portable SSD T5 500GB",
                        description = "Samsung Portable SSD T5 500GB USB 3.1 Type-C V-NAND TLC (MU-PA500B/WW) External",
                        img = "https://i1.rozetka.ua/goods/2270514/samsung_mu_pa500b_ww_images_2270514360.jpg",
                        price = 2899,
                        SsdCategory = SsdCategories["Flagman"]
                    },
                    new Ssd
                    {
                        name = "Verbatim SSD Vi500 S3 240GB",
                        description = "Verbatim SSD Vi500 S3 240GB 2.5 SATAIII 3D NAND TLC (70023)",
                        img = "https://i1.rozetka.ua/goods/8279155/verbatim_70023_images_8279155294.jpg",
                        price = 999,
                        SsdCategory = SsdCategories["Budget"]
                    }
                );
            }

            if (!content.VideoCardCategories.Any())
            {
                content.VideoCardCategories.AddRange(VideoCardCategories.Select(c => c.Value));
            }
            if (!content.VideoCards.Any())
            {
                content.AddRange(
                    new VideoCard
                    {
                        name = "Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus 8GB",
                        description = "Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus 8GB GDDR6 (256bit) (15500) (Type-C, 3 x HDMI, 3 x Display Port) (GV-N208SAORUS-8GC)",
                        img = "https://i2.rozetka.ua/goods/12839402/gigabyte_gv_n208saorus_8gc_images_12839402154.jpg",
                        price = 22688,
                        VideoCardCategory = VideoCardCategories["Flagman"]
                    },
                    new VideoCard
                    {
                        name = "Sapphire PCI-Ex Radeon RX 550 Pulse 2GB",
                        description = "Sapphire PCI-Ex Radeon RX 550 Pulse 2GB GDDR5 (128bit) (1071/6000) (DVI, HDMI, DisplayPort) (11268-16-20G)",
                        img = "https://i1.rozetka.ua/goods/14291798/sapphire_11268_16_20g_images_14291798161.jpg",
                        price = 2222,
                        VideoCardCategory = VideoCardCategories["Budget"]
                    },
                    new VideoCard
                    {
                        name = "Asus PCI-Ex Radeon RX580 ROG Strix OC 8GB",
                        description = "Asus PCI-Ex Radeon RX580 ROG Strix OC 8GB GDDR5 (256bit) (1360/8000) (DVI, 2 x HDMI, 2 x DisplayPort) (ROG-STRIX-RX580-O8G-GAMING)",
                        img = "https://i2.rozetka.ua/goods/1966299/asus_rog_strix_rx580_o8g_gaming_images_1966299098.jpg",
                        price = 6179,
                        VideoCardCategory = VideoCardCategories["Flagman"]
                    },
                    new VideoCard
                    {
                        name = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix Advanced 11GB",
                        description = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix Advanced 11GB GDDR6 (352bit) (1350/14000) (2xHDMI, 2xDisplayPort, Type-C) (ROG-STRIX-RTX2080TI-A11G-GAMING)",
                        img = "https://i1.rozetka.ua/goods/10552781/asus_rog_strix_rtx2080ti_a11g_gaming_images_10552781588.jpg",
                        price = 37670,
                        VideoCardCategory = VideoCardCategories["Flagman"]
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

        private static Dictionary<string, RamCategory> ramcategory;
        public static Dictionary<string, RamCategory> RamCategories
        {
            get
            {
                if (ramcategory == null)
                {
                    var list = new RamCategory[]
                    {
                        new RamCategory {categoryName = "Flagman", categoryDescription = "RAM with low path"},
                    new RamCategory {categoryName = "Budget", categoryDescription = "RAM with hight path"}
                    };
                    ramcategory = new Dictionary<string, RamCategory>();
                    foreach (RamCategory item in list)
                    {
                        ramcategory.Add(item.categoryName, item);
                    }
                }
                return ramcategory;
            }
        }

        private static Dictionary<string, SsdCategory> ssdcategory;
        public static Dictionary<string, SsdCategory> SsdCategories
        {
            get
            {
                if (ssdcategory == null)
                {
                    var list = new SsdCategory[]
                    {
                        new SsdCategory {categoryName = "Flagman", categoryDescription = "SSD with low path"},
                    new SsdCategory {categoryName = "Budget", categoryDescription = "SSD with hight path"}
                    };
                    ssdcategory = new Dictionary<string, SsdCategory>();
                    foreach (SsdCategory item in list)
                    {
                        ssdcategory.Add(item.categoryName, item);
                    }
                }
                return ssdcategory;
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
                        new ProcesorCategory {categoryName = "Flagman", categoryDescription = "Procesor with low path"},
                        new ProcesorCategory {categoryName = "Budget", categoryDescription = "Procesor with hight path"}
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

        private static Dictionary<string, VideoCardCategory> videoCardcategory;
        public static Dictionary<string, VideoCardCategory> VideoCardCategories
        {
            get
            {
                if (videoCardcategory == null)
                {
                    var list = new VideoCardCategory[]
                    {
                        new VideoCardCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                    new VideoCardCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                    };
                    videoCardcategory = new Dictionary<string, VideoCardCategory>();
                    foreach (VideoCardCategory item in list)
                    {
                        videoCardcategory.Add(item.categoryName, item);
                    }
                }
                return videoCardcategory;
            }
        }
    }
}
