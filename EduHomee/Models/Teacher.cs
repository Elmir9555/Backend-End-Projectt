using System;
using System.Collections.Generic;

namespace EduHomee.Models
{
    public class Teacher:BaseEntity
    {
        public string Fullname { get; set; }
        public string AboutMe { get; set; }
        public string Work { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string Mail { get; set; }
        public string MakeACall { get; set; }
        public string Skype { get; set; }


        //Relation Property
        public List<EventTeacher> EventTeachers { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
