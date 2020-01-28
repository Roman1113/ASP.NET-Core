using FirstProjectASP.NET.Core.Shop.Data.Interfaces;
using FirstProjectASP.NET.Core.Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectASP.NET.Core.Shop.Data.mocks
{
    public class MockCars : IAllCars{

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla",
                        shortDesc = "Швидкий авто",
                        longDesc = "Гарний, швидкий, дуже тихий",
                        img = "/img/Tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Не швидкий, тихий",
                        longDesc = "Гарний, дуже тихий",
                        img = "https://upload.wikimedia.org/wikipedia/commons/9/96/Ford_Fiesta_ST_%289913711886%29.jpg",
                        price = 10000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Nisan Leaf",
                        shortDesc = "Швидкий авто",
                        longDesc = "Гарний, швидкий, дуже тихий",
                        img = "https://ecoautoinfo.com/uploads/images/default/nissan_leaf.jpg",
                        price = 12000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Opel Vectra",
                        shortDesc = "Швидкий авто",
                        longDesc = "Гарний, стильний, класика",
                        img = "https://upload.wikimedia.org/wikipedia/commons/a/af/Opel_Vectra_front_20080118.jpg",
                        price = 5000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getOjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
