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
    public class EventTeacherController : Controller
    {

        // GET: /<controller>/
        readonly AppDbContext _context;
        public EventTeacherController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var list = await _context.EventTeachers.Include(x => x.Teacher).Include(x => x.Event).ToListAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var teachers = await _context.Teachers.ToListAsync();

            var skills = await _context.Events.ToListAsync();

            var teacherskill = new EventTeacher();

            return View((teacherskill, teachers, skills));
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] EventTeacher teacherSkill)
        {

            await _context.EventTeachers.AddAsync(teacherSkill);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "EventTeacher", new { area = "Admin" });
        }

        public async Task<IActionResult> Update(int id)
        {
            var teachers = await _context.Teachers.ToListAsync();

            var skills = await _context.Events.ToListAsync();

            var teacherskill = await _context.EventTeachers.Include(x => x.Teacher).Include(x => x.Event).FirstOrDefaultAsync(x => x.Id == id);

            return View((teacherskill, teachers, skills));
        }
        [HttpPost]
        public IActionResult Update([Bind(Prefix = "Item1")] EventTeacher teacherSkill)
        {

            _context.EventTeachers.Update(teacherSkill);
            _context.SaveChanges();

            return RedirectToAction("Index", "EventTeacher", new { area = "Admin" });
        }

        public IActionResult Delete(int id)
        {
            var teacherskill = _context.EventTeachers.Include(x => x.Teacher).Include(x => x.Event).FirstOrDefault(x => x.Id == id);
            _context.EventTeachers.Remove(teacherskill);
            _context.SaveChanges();

            return RedirectToAction("Index", "EventTeacher", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var teacherskill = await _context.EventTeachers.Include(x => x.Teacher).Include(x => x.Event).FirstOrDefaultAsync(x => x.Id == id);

            return View(teacherskill);
        }
    }
}
