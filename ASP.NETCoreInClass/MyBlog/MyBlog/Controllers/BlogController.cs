using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entityes;
using MyBlog.Interfaces;
using MyBlog.Models;
using MyBlog.ViewModel;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public BlogController(DBContext context, IPostRepository postRepository, IHostingEnvironment hostingEnvironment)
        {
        this.hostingEnvironment = hostingEnvironment;
            _postRepository = postRepository;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post(int id)
        {
            //var query = _context.Blog.AsQueryable();

            //var posts = query.Where(post => post.id == id).Select(p => new BlogModel
            //{
            //    id = p.id,
            //    title = p.title,
            //    author = p.author,
            //    fullPost = p.fullPost,
            //    img = p.img,
            //}).SingleOrDefault();
            var post = _postRepository.GetPostById(id);

            return View(post);
        }

    
        public IActionResult Delete(int id)
        {
            var post = _postRepository.GetPostById(id);
            if (post.img != null && post.img != "no.png")
            {
                //видаляємо фото з папки wwwroot по заданому шляху
                string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images", post.img);
                System.IO.File.Delete(filePath);
            }
            //видаляємо дані з бази по id
            _postRepository.DeletePost(id);
            //редірект на Блог
            return RedirectToAction("Index");

        }

        public IActionResult Index()
        {
            var posts = _postRepository.GetAllPosts().ToList(); 
            return View(posts);
        }
       

        [HttpGet]
        public ViewResult Edit(int id)
        {
            BlogModel post = _postRepository.GetPostById(id);
            PostEditViewModel postEditViewModel = new PostEditViewModel
            {
                Id = post.id,
                title = post.title,
                author = post.author,
                preview = post.preview,
                fullPost = post.fullPost,
                ExistImgPath = post.img
            };
            return View(postEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                BlogModel post = _postRepository.GetPostById(model.Id);
                post.author = model.author;
                post.title = model.title;
                post.preview = model.preview;
                post.fullPost = model.fullPost;

                if (model.img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    post.img = UploadedFile(model);
                }

                _postRepository.UpdatePost(post);
                return RedirectToAction("Index");
            }
            return View();
        }
        private string UploadedFile(PostEditViewModel model)
        {
            string uniqFileName = null;
            if (model.img != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.img.CopyTo(fileStream);
                }
            }

            return uniqFileName;
        }

        ////[Route("Blog/Delete/{id}")]
        //public IActionResult DeleteRep()
        //{
        //    return View();
        //}
    }
}