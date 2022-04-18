using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHomee.Datas;
using EduHomee.Models;
using EduHomee.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduHomee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        
       
            // GET: /<controller>/
            private readonly AppDbContext _context;
             private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }

            public async Task<IActionResult> Index()
            {
                About about = await _context.Abouts.Where(m => !m.IsDelete).OrderByDescending(m=>m.Id).FirstOrDefaultAsync();

                return View(about);
            }



        public async Task<IActionResult> Update()
        {
            About about = await _context.Abouts.FirstOrDefaultAsync();
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(About about)

        {
            var dbAbout = await _context.Abouts.FirstOrDefaultAsync();
            if (dbAbout == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();





            string path = Path.Combine(_env.WebRootPath, "assets/img/about", dbAbout.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + about.photo.FileName;
            string newPath = Path.Combine(_env.WebRootPath, "assets/img/about", fileName);


            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await about.photo.CopyToAsync(stream);
            }

            dbAbout.Image = fileName;
            dbAbout.Title = about.Title;
            dbAbout.Description = about.Description;
            

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





        public async Task<IActionResult> Detail(int id)
            {
                var about = await _context.Abouts.FindAsync(id);
                return View(about);
            }
        
    }
}
