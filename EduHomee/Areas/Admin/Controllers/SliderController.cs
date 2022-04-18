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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.Where(m => !m.IsDelete).ToListAsync();

            return View(sliders);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Create(SliderVM sliderVM)
        {

            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
            foreach (var photo in sliderVM.Photos)
            {
                if(!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            }

            foreach (var photo in sliderVM.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/img/slider", fileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                Slider slider = new Slider
                {
                    Image = fileName,
                    Title = sliderVM.Title,
                    Description = sliderVM.Desc


                };
                await _context.Sliders.AddAsync(slider);

            }




           
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Slider", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
           var slider= await _context.Sliders.FindAsync(id);
            SliderVM sliderVM = new SliderVM();
            return View(slider);

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,Slider slider)
        {
            var dbSlider = await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
           
                if (!slider.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            
            string path = Path.Combine(_env.WebRootPath, "assets/img/slider", dbSlider.Image);
            Helper.DeleteFile(path);

            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;
            string newpath = Path.Combine(_env.WebRootPath, "assets/img/slider", fileName);
            using (FileStream stream = new FileStream(newpath, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Description = slider.Description;
            dbSlider.Title = slider.Title;
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


            
         
        
        }



        public  IActionResult Delete(int id)
        {
            var slider =  _context.Sliders.Find(id);
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction("Index", "Slider", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            return View(slider);
        }




    }
}
