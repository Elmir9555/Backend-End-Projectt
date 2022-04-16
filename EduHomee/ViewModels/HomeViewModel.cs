using System;
using System.Collections.Generic;
using EduHomee.Models;

namespace EduHomee.ViewModels
{
    public class HomeViewModel
    {
        public About About { get; set; }
        public List<BioTable> BioTables { get; set; }
        public Contact Contact { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseDetails> CourseDetails { get; set; }
        public List<CourseFeatures> CourseFeatures { get; set; }
        public List<Event> Events { get; set; }
        public List<EventTeacher> EventTeachers { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<Service> Services { get; set; }
        public List<Skill> Skills{ get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Social> Socials { get; set; }
        public List<TagTable> TagTables { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Blog> Blogs { get; set; }


    }
}
