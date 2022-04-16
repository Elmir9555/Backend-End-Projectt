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
    public class ServiceController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Service> services = await _context.Services.Where(m => !m.IsDelete).ToListAsync();

            return View(services);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Service service)
        {

            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Service", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var service = await _context.Services.FindAsync(id);
            return View(service);

        }

        [HttpPost]
        public IActionResult Update(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("Index", "Service", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var service = _context.Services.Find(id);
            _context.Services.Remove(service);
            _context.SaveChanges();
            return RedirectToAction("Index", "Service", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var service = await _context.Services.FindAsync(id);
            return View(service);
        }
    }
}
