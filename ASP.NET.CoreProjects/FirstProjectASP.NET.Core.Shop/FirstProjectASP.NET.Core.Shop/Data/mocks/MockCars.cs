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
                        img = "",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
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
