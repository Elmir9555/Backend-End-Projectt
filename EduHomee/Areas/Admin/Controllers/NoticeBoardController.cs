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
    public class NoticeBoardController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _context;

        public NoticeBoardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<NoticeBoard> noticeBoards = await _context.NoticeBoards.Where(m => !m.IsDelete).ToListAsync();

            return View(noticeBoards);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(NoticeBoard noticeBoard)
        {

            await _context.NoticeBoards.AddAsync(noticeBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "NoticeBoard", new { area = "Admin" });

        }

        public async Task<IActionResult> Update(int id)
        {
            var noticeBoard = await _context.NoticeBoards.FindAsync(id);
            return View(noticeBoard);

        }

        [HttpPost]
        public IActionResult Update(NoticeBoard noticeBoard)
        {
            _context.NoticeBoards.Update(noticeBoard);
            _context.SaveChanges();
            return RedirectToAction("Index", "NoticeBoard", new { area = "Admin" });
        }



        public IActionResult Delete(int id)
        {
            var noticeBoard = _context.NoticeBoards.Find(id);
            _context.NoticeBoards.Remove(noticeBoard);
            _context.SaveChanges();
            return RedirectToAction("Index", "NoticeBoard", new { area = "Admin" });
        }

        public async Task<IActionResult> Detail(int id)
        {
            var noticeBoard = await _context.NoticeBoards.FindAsync(id);
            return View(noticeBoard);
        }
    }
}
