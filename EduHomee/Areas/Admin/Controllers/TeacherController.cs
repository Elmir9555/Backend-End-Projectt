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
    public class TeacherController : Controller
    {
        // GET: /<controller>/


        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _context.Teachers.Where(m => !m.IsDelete).ToListAsync();

            return View(teachers);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Teacher teacher)
        {

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Teacher", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            return View(teacher);

        }

        [HttpPost]
        public IActionResult Update(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return RedirectToAction("Index", "Teacher", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return RedirectToAction("Index", "Teacher", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            return View(teacher);
        }
    }   
}
