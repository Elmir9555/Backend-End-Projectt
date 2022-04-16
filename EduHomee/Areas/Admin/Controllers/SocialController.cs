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
{   [Area("Admin")]
    public class SocialController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public SocialController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Social> socials = await _context.Socials.Where(m => !m.IsDelete).ToListAsync();

            return View(socials);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Social social)
        {

            await _context.Socials.AddAsync(social);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Social", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var social = await _context.Socials.FindAsync(id);
            return View(social);

        }

        [HttpPost]
        public IActionResult Update(Social social)
        {
            _context.Socials.Update(social);
            _context.SaveChanges();
            return RedirectToAction("Index", "Social", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var social = _context.Socials.Find(id);
            _context.Socials.Remove(social);
            _context.SaveChanges();
            return RedirectToAction("Index", "Social", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var social = await _context.Socials.FindAsync(id);
            return View(social);
        }
    }
}
