using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyIntroShop2._2.Controllers 
{
    public class MotherboardController : Controller
    {
        private readonly IAllMotherboards _allMotherboards;
        private readonly IMotherboardsCategory _allMotherboardCategories;

        public MotherboardController(IAllMotherboards iallMotherboards, IMotherboardsCategory imotherboardCategory)
        {
            _allMotherboards = iallMotherboards;
            _allMotherboardCategories = imotherboardCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Motherboard";
            MotherboardListViewModel obj = new MotherboardListViewModel();
            obj.allMotherboards = _allMotherboards.motherboards;
            obj.currentCategory = "Motherboards : ";

            return View(obj);
        }
    }
}
