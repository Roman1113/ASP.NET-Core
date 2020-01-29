using FirstProjectASP.NET.Core.Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectASP.NET.Core.Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getOjectCar(int carId);
    }
}
