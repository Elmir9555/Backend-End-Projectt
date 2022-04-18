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
    public class BlogController : Controller
    {
        // GET: /<controller>/
      
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync()
        {

            About about = await _context.Abouts.FirstOrDefaultAsync();
           
            List<NoticeBoard> noticeBoards = await _context.NoticeBoards.ToListAsync();
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            List<BioTable> bioTables = await _context.BioTables.ToListAsync();
            Contact contact = await _context.Contacts.FirstOrDefaultAsync();
            List<Course> courses = await _context.Courses.Include(m => m.CourseFeatures).Include(m => m.CourseDetails).ToListAsync();
            List<CourseDetails> courseDetails = await _context.CourseDetails.ToListAsync();
            List<Event> events = await _context.Events.ToListAsync();
            List<EventTeacher> eventTeachers = await _context.EventTeachers.ToListAsync();
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
                Sliders = sliders,
                Services = services,
                About = about,
                Courses = courses,
                NoticeBoards = noticeBoards,
                Events = events,
                BioTables = bioTables,
                Contact = contact,
                Blogs=blogs,
                CourseDetails = courseDetails,

                EventTeachers = eventTeachers,


                Skills = skills,

                Socials = socials,
                TagTables = tagTables,
                Teachers = teachers,
                TeacherSkills = teacherSkills,
                Testimonials = testimonials



            };
            return View(HomeVm);
        }
    }
}
