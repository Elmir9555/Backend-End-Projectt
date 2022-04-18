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
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Course>courses = await _context.Courses.Where(m => !m.IsDelete).ToListAsync();

            return View(courses);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CourseVM courseVM)
        {

            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
            foreach (var photo in courseVM.Photos)
            {
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            }

            foreach (var photo in courseVM.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/img/course", fileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                Course course=new Course
                {
                    Image = fileName,
                    Title = courseVM.Title,
                    Description = courseVM.Desc


                };
                await _context.Courses.AddAsync(course);

            }





            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Course", new { area = "Admin" });

        }


        public async Task<IActionResult> Update(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            CourseVM courseVM = new CourseVM();
            return View(course);

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Course course)
        {
            var dbSlider = await _context.Courses.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();

            if (!course.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photos", "Image type is wrong");
            }


            string path = Path.Combine(_env.WebRootPath, "assets/img/course", dbSlider.Image);
            Helper.DeleteFile(path);

            string fileName = Guid.NewGuid().ToString() + "_" + course.Photo.FileName;
            string newpath = Path.Combine(_env.WebRootPath, "assets/img/course", fileName);
            using (FileStream stream = new FileStream(newpath, FileMode.Create))
            {
                await course.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Description = course.Description;
            dbSlider.Title = course.Title;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));





        }



        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index", "Course", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            return View(course);
        }
    
    }
}
