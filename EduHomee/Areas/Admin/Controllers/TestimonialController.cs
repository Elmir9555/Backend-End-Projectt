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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TestimonialController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Testimonial> testimonials = await _context.Testimonials.Where(m => !m.IsDelete).ToListAsync();

            return View(testimonials);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(TestimonialVM testimonialVM)
        {

            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
            foreach (var photo in testimonialVM.Photos)
            {
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            }

            foreach (var photo in testimonialVM.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/img/testimonial", fileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                Testimonial testimonial=new Testimonial
                {
                    Image = fileName,
                    Fullname = testimonialVM.Fullname,
                    Description = testimonialVM.Description,
                    Work=testimonialVM.Work
                    


                };
                await _context.Testimonials.AddAsync(testimonial);

            }





            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Testimonial", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);
            TestimonialVM testimonialVM = new TestimonialVM();
            return View(testimonial);

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Testimonial testimonial)
        {
            var dbSlider = await _context.Testimonials.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();

            if (!testimonial.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photos", "Image type is wrong");
            }


            string path = Path.Combine(_env.WebRootPath, "assets/img/testimonial", dbSlider.Image);
            Helper.DeleteFile(path);

            string fileName = Guid.NewGuid().ToString() + "_" + testimonial.Photo.FileName;
            string newpath = Path.Combine(_env.WebRootPath, "assets/img/testimonial", fileName);
            using (FileStream stream = new FileStream(newpath, FileMode.Create))
            {
                await testimonial.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Description = testimonial.Description;
            dbSlider.Fullname = testimonial.Fullname;
            dbSlider.Work = testimonial.Work;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));





        }



        public IActionResult Delete(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index", "Testimonial", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);
            return View(testimonial);
        }
    }
}
