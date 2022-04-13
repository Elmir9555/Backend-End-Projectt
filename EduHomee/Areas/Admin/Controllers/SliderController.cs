using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomee.Datas;
using EduHomee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduHomee.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
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
      
        public async Task<IActionResult> Create(Slider slider)
        {

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Slider", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
           var slider= await _context.Sliders.FindAsync(id);
            return View(slider);

        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            _context.Sliders.Update(slider);
            _context.SaveChanges();
            return RedirectToAction("Index", "Slider", new { area = "Admin" });
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
