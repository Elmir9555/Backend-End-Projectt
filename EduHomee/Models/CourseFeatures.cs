using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class CourseFeatures:BaseEntity
    {
        [Required(ErrorMessage = "Start Boş keçilə bilməz")]
        public string Start { get; set; }
        [Required(ErrorMessage = "Duration Boş keçilə bilməz")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "ClassDuration Boş keçilə bilməz")]
        public string ClassDuration { get; set; }
        [Required(ErrorMessage = "Language Boş keçilə bilməz")]
        public string Language { get; set; }
        [Required(ErrorMessage = "SkillLevel Boş keçilə bilməz")]
        public string SkillLevel { get; set; }
        [Required(ErrorMessage = "Students Boş keçilə bilməz")]
        public string Students { get; set; }
        [Required(ErrorMessage = "Assesments Boş keçilə bilməz")]
        public string Assesments { get; set; }
        [Required(ErrorMessage = "CourseFee Boş keçilə bilməz")]
        public string CourseFee { get; set; }

        public int CourseId { get; set; }
        //Relation Property

        public Course Course { get; set; }
    }
}
