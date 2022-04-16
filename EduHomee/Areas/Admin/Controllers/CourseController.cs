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
    public class CourseController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Create(Course course)
        {

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Course", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            return View(course);

        }

        [HttpPost]
        public IActionResult Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction("Index", "Course", new { area = "Admin" });
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
