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
    public class CourseFeaturesController : Controller
    {
        // GET: /<controller>/
        readonly AppDbContext _context;
        public CourseFeaturesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var courseFeatures = await _context.CourseFeatures.Where(x => !x.IsDelete).Include(x => x.Course).ToListAsync();

            return View(courseFeatures);
        }


        public IActionResult Create()
        {
            var courselist = _context.Courses.ToList();

            var courseFeatures = new CourseFeatures();

            return View((courseFeatures, courselist));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] CourseFeatures courseFeatures)
        {
            _context.CourseFeatures.Add(courseFeatures);
            _context.SaveChanges();

            return RedirectToAction("Index", "CourseFeatures", new { area = "Admin" });
        }

        public async Task<IActionResult> Update(int id)
        {
            var courseFeatures = await _context.CourseFeatures.FindAsync(id);
            var course = await _context.Courses.ToListAsync();

            return View((courseFeatures, course));
        }
        [HttpPost]
        public IActionResult Update([Bind(Prefix = "Item1")] CourseFeatures courseFeatures)
        {
            _context.CourseFeatures.Update(courseFeatures);
            _context.SaveChanges();

            return RedirectToAction("Index", "CourseFeatures", new { area = "Admin" });
        }

        public IActionResult Delete(int id)
        {
            var courseFeatures = _context.CourseFeatures.Find(id);
            _context.CourseFeatures.Remove(courseFeatures);
            _context.SaveChanges();
            return RedirectToAction("Index", "CourseFeatures", new { area = "Admin" });
        }

        public IActionResult Detail(int id)
        {
            var courseFeatures = _context.CourseFeatures.Include(x => x.Course).FirstOrDefault(x => x.Id == id);
            return View(courseFeatures);
        }
    }
}
