using FirstProjectASP.NET.Core.Shop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla",
                         shortDesc = "Швидкий авто",
                         longDesc = "Гарний, швидкий, дуже тихий",
                         img = "/img/Tesla.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Електроавтомобілі"]
                     },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Не швидкий, тихий",
                        longDesc = "Гарний, дуже тихий",
                        img = "https://upload.wikimedia.org/wikipedia/commons/9/96/Ford_Fiesta_ST_%289913711886%29.jpg",
                        price = 10000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Клаичні авто"]
                    },
                    new Car
                    {
                        name = "Nisan Leaf",
                        shortDesc = "Швидкий авто",
                        longDesc = "Гарний, швидкий, дуже тихий",
                        img = "https://ecoautoinfo.com/uploads/images/default/nissan_leaf.jpg",
                        price = 12000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Електроавтомобілі"]
                    },
                    new Car
                    {
                        name = "Opel Vectra",
                        shortDesc = "Швидкий авто",
                        longDesc = "Гарний, стильний, класика",
                        img = "https://upload.wikimedia.org/wikipedia/commons/a/af/Opel_Vectra_front_20080118.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Клаичні авто"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category {categoryname = "Електроавтомобілі", desc="Сучасні авто"},
                    new Category {categoryname = "Клаичні авто", desc="Авто з двигуном внутрішнього згорання"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryname, el);
                }
                return category;
            }
        }
    }
}
