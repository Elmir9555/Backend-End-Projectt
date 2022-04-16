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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Create(Testimonial testimonial)
        {

            await _context.Testimonials.AddAsync(testimonial);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Testimonial", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);
            return View(testimonial);

        }

        [HttpPost]
        public IActionResult Update(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index", "Testimonial", new { area = "Admin" });
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
