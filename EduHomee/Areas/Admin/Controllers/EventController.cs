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
    public class EventController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public EventController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Event> events = await _context.Events.Where(m => !m.IsDelete).ToListAsync();

            return View(events);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(EventVM eventVM)
        {

            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();
            foreach (var photo in eventVM.Photos)
            {
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Image type is wrong");
                }

            }

            foreach (var photo in eventVM.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "assets/img/event", fileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                Event evt=new Event
                {
                    Image = fileName,
                    Title = eventVM.Title,
                    Description = eventVM.Desc


                };
                await _context.Events.AddAsync(evt);

            }





            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Event", new { area = "Admin" });

        }
        public async Task<IActionResult> Update(int id)
        {
            var evt = await _context.Events.FindAsync(id);
            EventVM eventVM = new EventVM();
            return View(evt);

        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Event evt)
        {
            var dbSlider = await _context.Events.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (ModelState.ValidationState == ModelValidationState.Invalid) return View();

            if (!evt.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photos", "Image type is wrong");
            }


            string path = Path.Combine(_env.WebRootPath, "assets/img/event", dbSlider.Image);
            Helper.DeleteFile(path);

            string fileName = Guid.NewGuid().ToString() + "_" + evt.Photo.FileName;
            string newpath = Path.Combine(_env.WebRootPath, "assets/img/event", fileName);
            using (FileStream stream = new FileStream(newpath, FileMode.Create))
            {
                await evt.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            dbSlider.Description = evt.Description;
            dbSlider.Title =evt.Title;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));





        }


        public IActionResult Delete(int id)
        {
            var evt = _context.Events.Find(id);
            _context.Events.Remove(evt);
            _context.SaveChanges();
            return RedirectToAction("Index", "Event", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var evt = await _context.Events.FindAsync(id);
            return View(evt);
        }


    }
}
