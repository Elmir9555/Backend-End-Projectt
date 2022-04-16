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
    public class TagTableController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public TagTableController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<TagTable> tagTables = await _context.TagTables.Where(m => !m.IsDelete).ToListAsync();

            return View(tagTables);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(TagTable tagTable)
        {

            await _context.TagTables.AddAsync(tagTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "TagTable", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var tagTable = await _context.TagTables.FindAsync(id);
            return View(tagTable);

        }

        [HttpPost]
        public IActionResult Update(TagTable tagTable)
        {
            _context.TagTables.Update(tagTable);
            _context.SaveChanges();
            return RedirectToAction("Index", "TagTable", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var tagTable = _context.TagTables.Find(id);
            _context.TagTables.Remove(tagTable);
            _context.SaveChanges();
            return RedirectToAction("Index", "TagTable", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var tagTable = await _context.TagTables.FindAsync(id);
            return View(tagTable);
        }
    }
}
