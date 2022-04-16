using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class CourseDetails:BaseEntity
    { 
        [Required(ErrorMessage = "About Boş keçilə bilməz")]
        public string About { get; set; }
        [Required(ErrorMessage = "Certificate Boş keçilə bilməz")]
        public string Certificate { get; set; }
        [Required(ErrorMessage = "How to Apply Boş keçilə bilməz")]
        public string HowToApply { get; set; }
        [Required(ErrorMessage = "CourseCount Boş keçilə bilməz")]
        public int CourseCount { get; set; }

        
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
