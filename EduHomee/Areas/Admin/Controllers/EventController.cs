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
    public class EventController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Event> events = await _context.Events.Where(m => !m.IsDelete).ToListAsync();

            return View(events);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Event evt)
        {

            await _context.Events.AddAsync(evt);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Event", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var evt = await _context.Events.FindAsync(id);
            return View(evt);

        }

        [HttpPost]
        public IActionResult Update(Event evt)
        {
            _context.Events.Update(evt);
            _context.SaveChanges();
            return RedirectToAction("Index", "Event", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var evt = _context.Events.Find(id);
            _context.Events.Remove(evt);
            _context.SaveChanges();
            return RedirectToAction("Index", "Event", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var evt = await _context.Events.FindAsync(id);
            return View(evt);
        }


    }
}
