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
    public class AboutController : Controller
    {
        
       
            // GET: /<controller>/
            private readonly AppDbContext _context;

            public AboutController(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
                About about = await _context.Abouts.Where(m => !m.IsDelete).OrderByDescending(m=>m.Id).FirstOrDefaultAsync();

                return View(about);
            }

          

            public async Task<IActionResult> Update(int id)
            {
                var about = await _context.Abouts.FindAsync(id);
                return View(about);

            }

            [HttpPost]
            public IActionResult Update(About about)
            {
                _context.Abouts.Update(about);
                _context.SaveChanges();
                return RedirectToAction("Index", "About", new { area = "Admin" });
            }



         

            public async Task<IActionResult> Detail(int id)
            {
                var about = await _context.Abouts.FindAsync(id);
                return View(about);
            }
        
    }
}
