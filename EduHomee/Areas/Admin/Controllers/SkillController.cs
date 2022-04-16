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
    public class SkillController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Skill> skills = await _context.skills.Where(m => !m.IsDelete).ToListAsync();

            return View(skills);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Skill skill)
        {

            await _context.skills.AddAsync(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Skill", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var skill = await _context.skills.FindAsync(id);
            return View(skill);

        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            _context.skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index", "Skill", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var skill = _context.skills.Find(id);
            _context.skills.Remove(skill);
            _context.SaveChanges();
            return RedirectToAction("Index", "Skill", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var skill = await _context.skills.FindAsync(id);
            return View(skill);
        }

    }
}
