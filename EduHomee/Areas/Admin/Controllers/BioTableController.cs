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
    public class BioTableController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public BioTableController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<BioTable> bioTables = await _context.BioTables.Where(m => !m.IsDelete).ToListAsync();

            return View(bioTables);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(BioTable bioTable)
        {

            await _context.BioTables.AddAsync(bioTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "BioTable", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var bioTable = await _context.BioTables.FindAsync(id);
            return View(bioTable);

        }

        [HttpPost]
        public IActionResult Update(BioTable bioTable)
        {
            _context.BioTables.Update(bioTable);
            _context.SaveChanges();
            return RedirectToAction("Index", "BioTable", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var bioTable = _context.BioTables.Find(id);
            _context.BioTables.Remove(bioTable);
            _context.SaveChanges();
            return RedirectToAction("Index", "BioTable", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var bioTable = await _context.BioTables.FindAsync(id);
            return View(bioTable);
        }
    }
}
