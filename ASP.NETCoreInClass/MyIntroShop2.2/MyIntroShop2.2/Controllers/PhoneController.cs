using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyIntroShop2._2.Controllers 
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhoneCategory _allCategories;

        public PhoneController(IAllPhones iallPhones, IPhoneCategory iphoneCategory)
        {
            _allPhones = iallPhones;
            _allCategories = iphoneCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Phone";
            PhoneListViewModel obj = new PhoneListViewModel();
            obj.allPhones = _allPhones.phones;
            obj.currentCategory = "Phone: ";

            return View(obj);
        }
    }
}
