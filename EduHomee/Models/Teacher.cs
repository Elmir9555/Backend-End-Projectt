using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Teacher:BaseEntity
    {
        [Required(ErrorMessage = "FullName Boş keçilə bilməz")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "AboutMe Boş keçilə bilməz")]
        public string AboutMe { get; set; }
        [Required(ErrorMessage = "Work Boş keçilə bilməz")]
        public string Work { get; set; }
        [Required(ErrorMessage = "Degree Boş keçilə bilməz")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Experience Boş keçilə bilməz")]
        public string Experience { get; set; }
        [Required(ErrorMessage = "Hobbies Boş keçilə bilməz")]
        public string Hobbies { get; set; }
        [Required(ErrorMessage = "Faculty Boş keçilə bilməz")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Mail Boş keçilə bilməz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "MakeACall Boş keçilə bilməz")]
        public string MakeACall { get; set; }
        [Required(ErrorMessage = "Skype Boş keçilə bilməz")]
        public string Skype { get; set; }


        //Relation Property
        public List<EventTeacher> EventTeachers { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
