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
    public class TeacherSkillController : Controller
    {
        // GET: /<controller>/
        readonly AppDbContext _context;
        public TeacherSkillController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var list = await _context.TeacherSkills.Include(x => x.Skill).Include(x => x.Teacher).ToListAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var teachers = await _context.Teachers.ToListAsync();

            var skills = await _context.skills.ToListAsync();

            var teacherskill = new TeacherSkill();

            return View((teacherskill, teachers, skills));
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] TeacherSkill teacherSkill)
        {
            await _context.TeacherSkills.AddAsync(teacherSkill);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "TeacherSkill", new { area = "Admin" });
        }

        public async Task<IActionResult> Update(int id)
        {
            var teachers = await _context.Teachers.ToListAsync();

            var skills = await _context.skills.ToListAsync();

            var teacherskill = await _context.TeacherSkills.Include(x => x.Teacher).Include(x => x.Skill).FirstOrDefaultAsync(x => x.Id == id);

            return View((teacherskill, teachers, skills));
        }
        [HttpPost]
        public IActionResult Update([Bind(Prefix = "Item1")] TeacherSkill teacherSkill)
        {
            _context.TeacherSkills.Update(teacherSkill);
            _context.SaveChanges();
            return RedirectToAction("Index", "TeacherSkill", new { area = "Admin" });
        }

        public IActionResult Delete(int id)
        {
            var teacherskill = _context.TeacherSkills.Include(x => x.Teacher).Include(x => x.Skill).FirstOrDefault(x => x.Id == id);
            _context.TeacherSkills.Remove(teacherskill);
            _context.SaveChanges();

            return RedirectToAction("Index", "TeacherSkill", new { area = "Admin" });
        }

        public async Task<IActionResult> Details(int id)
        {
            var teacherskill = await _context.TeacherSkills.Include(x => x.Teacher).Include(x => x.Skill).FirstOrDefaultAsync(x => x.Id == id);

            return View(teacherskill);
        }
    }
}
