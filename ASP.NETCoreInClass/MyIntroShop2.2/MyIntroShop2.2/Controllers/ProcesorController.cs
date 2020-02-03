using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyIntroShop2._2.Controllers 
{
    public class ProcesorController : Controller
    {
        private readonly IAllProcesors _allProcesors;
        private readonly IProcesorCategory _procesorCategory;

        public ProcesorController(IAllProcesors iallProcesors, IProcesorCategory iprocesorCategory)
        {
            _allProcesors = iallProcesors;
            _procesorCategory = iprocesorCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Procesor";
            ProcesorListViewModel obj = new ProcesorListViewModel();
            obj.allProcesors = _allProcesors.procesors;
            obj.currentCategory = "Procesor : ";

            return View(obj);
        }
    }
}
