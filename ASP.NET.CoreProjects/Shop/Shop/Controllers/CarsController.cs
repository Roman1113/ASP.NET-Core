using FirstProjectASP.NET.Core.Shop.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.carrCategory = "Avto";

            return View(obj);
        }
    }
}
