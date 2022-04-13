using System;
using EduHomee.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHomee.Datas
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new CourseConfigurations());
        //    modelBuilder.ApplyConfiguration(new EventTeacherConfiguration());
        //    modelBuilder.ApplyConfiguration(new TeacherSkillConfiguration());

        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<BioTable> BioTables { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventTeacher> EventTeachers { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<TagTable> TagTables { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }





    }
}
