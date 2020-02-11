﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MyBlog.Interfaces;
using MyBlog.Migrations;
using MyBlog.Models;
using MyBlog.ViewModel;

namespace MyBlog.Controllers
{
    public class AdminController : Controller
    {

        private IPostRepository _postRep;
        private IHostingEnvironment hostingEnvironment;
        public AdminController(IPostRepository postRep, IHostingEnvironment hostingEnvironment)
        {
            _postRep = postRep;
            this.hostingEnvironment = hostingEnvironment;
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
        public IActionResult CreatePost(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (model.img != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    model.img.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                else
                {
                    uniqFileName = "noimage.png";
                }
                BlogModel newPost = new BlogModel
                {
                    author = model.author,
                    title = model.title,
                    preview = model.preview,
                    fullPost = model.fullPost,
                    img = uniqFileName
                };
                _postRep.CreatePost(newPost);

                //return RedirectToAction("CreatePost", new RouteValueDictionary(
                //                new { controller = "Blog", action = "Post", Id = newPost.id }));

            }
            
            return Redirect("~/Blog/Index");
        }
    }
}