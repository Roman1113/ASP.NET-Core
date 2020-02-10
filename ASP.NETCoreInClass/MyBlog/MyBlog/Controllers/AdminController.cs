using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Interfaces;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class AdminController : Controller
    {

        private IPostRepository _postRep;
        public AdminController(IPostRepository postRep)
        {
            _postRep = postRep;
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult PostEditor(int postID)
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(BlogModel post)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}