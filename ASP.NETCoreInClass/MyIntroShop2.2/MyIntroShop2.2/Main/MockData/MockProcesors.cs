using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockProcesor : IAllProcesors
    {

        private readonly IProcesorCategory _procesorCategory = new MockProcesorCategory();
        public IEnumerable<Procesor> procesors
        {
            get
            {
                return new List<Procesor>
                {
                    new Procesor
                    {
                        name = "Процесор AMD Ryzen 5 3600 3.6 GHz",
                        description = "Процесор AMD Ryzen 5 3600 3.6 GHz / 32MB sAM4 BOX",
                        img = "https://i2.rozetka.ua/goods/12765144/amd_ryzen_5_3600_images_12765144943.jpg",
                        price = 5880,
                        ProcesorCategory = _procesorCategory.AllProcesorsCategories.First()
                    },
                    new Procesor
                    {
                        name = "Процесор Intel Core i5-9400 2.9 GHz ",
                        description = "Процесор Intel Core i5-9400 2.9 GHz / 8GT / s / 9MB (BX80684I59400) s1151 BOX",
                        img = "https://i2.rozetka.ua/goods/13118701/intel_core_i5_9400_bx80684i59400_images_13118701380.jpg",
                        price = 5835,
                        ProcesorCategory = _procesorCategory.AllProcesorsCategories.Last()
                    },
                    new Procesor
                    {
                        name = "Процесор Intel Core i9-9900 3.1GHz",
                        description = "Процесор Intel Core i9-9900 3.1GHz / 8GT / s / 16MB (BX80684I99900) s1151 BOX",
                        img = "https://i2.rozetka.ua/goods/13345472/intel_core_i9_9900_bx80684i99900_images_13345472200.jpg",
                        price = 13750,
                        ProcesorCategory = _procesorCategory.AllProcesorsCategories.First()
                    },
                    new Procesor
                    {
                        name = "HP Intel Xeon E5",
                        description = "HP Intel Xeon E5-2609v3 DL160 Gen9 Kit (733943-B21)",
                        img = "https://i1.rozetka.ua/goods/2020325/hp_733943_b21_images_2020325947.jpg",
                        price = 14999,
                        ProcesorCategory = _procesorCategory.AllProcesorsCategories.First()
                    }
                };
            }
        }
    }
}
