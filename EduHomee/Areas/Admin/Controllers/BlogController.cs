using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHomee.Datas;
using EduHomee.Models;
using EduHomee.Utilities;
using EduHomee.ViewModels.Admin;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduHomee.Areas.Admin.Controllers
{   [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context; ;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.Where(m => !m.IsDelete).ToListAsync();

            return View(blogs);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BlogVM blogVM)
        {

            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
            foreach (var photo in blogVM.Photos)
            {
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            }

            foreach (var photo in blogVM.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/img/blog", fileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                Blog blog=new Blog
                {
                    Image = fileName,
                    Date = blogVM.Date,
                    Description = blogVM.Description,
                    TeacherName=blogVM.TeacherName,

                    


                };
                await _context.Blogs.AddAsync(blog);

            }





            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Blog", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            BlogVM blogVM = new BlogVM();
            return View(blog);

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Blog blog)
        {
            var dbSlider = await _context.Blogs.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();

            if (!blog.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photos", "Image type is wrong");
            }


            string path = Path.Combine(_env.WebRootPath, "assets/img/blog", dbSlider.Image);
            Helper.DeleteFile(path);

            string fileName = Guid.NewGuid().ToString() + "_" + blog.Photo.FileName;
            string newpath = Path.Combine(_env.WebRootPath, "assets/img/blog", fileName);
            using (FileStream stream = new FileStream(newpath, FileMode.Create))
            {
                await blog.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Description = blog.Description;
            dbSlider.Date = blog.Date;
            dbSlider.TeacherName = blog.TeacherName;
           



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));





        }




        public IActionResult Delete(int id)
        {
            var blog = _context.Blogs.Find(id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index", "Blog", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            return View(blog);
        }
    }
}
