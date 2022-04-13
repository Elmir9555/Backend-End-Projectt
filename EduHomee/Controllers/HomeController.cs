using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomee.Datas;
using EduHomee.Models;
using EduHomee.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduHomee.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        


        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            About about = await _context.Abouts.FirstOrDefaultAsync();
            List<BioTable> bioTables = await _context.BioTables.ToListAsync();
            Contact contact = await _context.Contacts.FirstOrDefaultAsync();
            List<Course> courses = await _context.Courses.ToListAsync();
            List<CourseDetails> courseDetails = await _context.CourseDetails.ToListAsync();
            List<Event> events = await _context.Events.ToListAsync();
            List<EventTeacher> eventTeachers = await _context.EventTeachers.ToListAsync();
            NoticeBoard noticeBoard = await _context.NoticeBoards.FirstOrDefaultAsync();
            List<Service> services = await _context.Services.ToListAsync();
            List<Skill> skills = await _context.skills.ToListAsync();
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<Social> socials = await _context.Socials.ToListAsync();
            List<TagTable> tagTables = await _context.TagTables.ToListAsync();
            List<Teacher> teachers = await _context.Teachers.ToListAsync();
            List<TeacherSkill> teacherSkills = await _context.TeacherSkills.ToListAsync();
            List<Testimonial> testimonials = await _context.Testimonials.ToListAsync();


            HomeViewModel HomeVm = new HomeViewModel
            {
                About = about,
                BioTables = bioTables,
                Contact = contact,
                Courses = courses,
                CourseDetails = courseDetails,
                Events = events,
                EventTeachers = eventTeachers,
                NoticeBoard = noticeBoard,
                Services = services,
                Skills = skills,
                Sliders = sliders,
                Socials = socials,
                TagTables = tagTables,
                Teachers=teachers,
                TeacherSkills=teacherSkills,
                Testimonials=testimonials



            };

            return View(HomeVm);
        }
    }
}
