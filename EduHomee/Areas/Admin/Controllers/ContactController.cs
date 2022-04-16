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
    public class ContactController : Controller
    {
        // GET: /<controller>/

        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Contact> contacts = await _context.Contacts.Where(m => !m.IsDelete).ToListAsync();

            return View(contacts);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Contact contact)
        {

            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Contact", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            return View(contact);

        }

        [HttpPost]
        public IActionResult Update(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Contact", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Contact", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            return View(contact);
        }

    }
}
