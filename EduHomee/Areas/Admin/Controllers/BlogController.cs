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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.Where(m => !m.IsDelete).ToListAsync();

            return View(blogs);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Blog blog)
        {

            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Blog", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            return View(blog);

        }

        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            _context.Blogs.Update(blog);
            _context.SaveChanges();
            return RedirectToAction("Index", "Blog", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var blog = _context.Blogs.Find(id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index", "Blog", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            return View(blog);
        }
    }
}
