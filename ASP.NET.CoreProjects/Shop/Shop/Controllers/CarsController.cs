using FirstProjectASP.NET.Core.Shop.Data.Interfaces;
using FirstProjectASP.NET.Core.Shop.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory icarsCategory)
        {
            _allCars = iallCars;
            _allCategories = icarsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryname.Equals("Електроавтомобілі")).OrderBy(i => i.id);
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryname.Equals("Клаичні авто")).OrderBy(i => i.id);
                }
                currCategory = _category;
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carrCategory = currCategory
            };

            ViewBag.Title = "Сторінка з авто";
       
            return View(carObj);
        }
    }
}
