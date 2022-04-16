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
    public class CourseDetailsController : Controller
    {
        // GET: /<controller>/

        readonly AppDbContext _context;
        public CourseDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var coursedeatils = await _context.CourseDetails.Where(x=>!x.IsDelete).Include(x => x.Course).ToListAsync();

            return View(coursedeatils);
        }


        public IActionResult Create()
        {
            var courselist = _context.Courses.ToList();

            var coursedetails = new CourseDetails();

            return View((coursedetails, courselist));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] CourseDetails details)
        {
            _context.CourseDetails.Add(details);
            _context.SaveChanges();

            return RedirectToAction("Index", "CourseDetails", new { area = "Admin" });
        }

        public async Task<IActionResult> Update(int id)
        {
            var details = await _context.CourseDetails.FindAsync(id);
            var course = await _context.Courses.ToListAsync();

            return View((details, course));
        }
        [HttpPost]
        public IActionResult Update([Bind(Prefix = "Item1")] CourseDetails details)
        {
            _context.CourseDetails.Update(details);
            _context.SaveChanges();

            return RedirectToAction("Index", "CourseDetails", new { area = "Admin" });
        }

        public IActionResult Delete(int id)
        {
            var details = _context.CourseDetails.Find(id);
            _context.CourseDetails.Remove(details);
            _context.SaveChanges();
            return RedirectToAction("Index", "CourseDetails", new { area = "Admin" });
        }

        public IActionResult Detail(int id)
        {
            var details = _context.CourseDetails.Include(x => x.Course).FirstOrDefault(x => x.Id == id);
            return View(details);
        }

    }
}
