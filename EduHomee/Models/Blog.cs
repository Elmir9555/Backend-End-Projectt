using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Blog:BaseEntity

    {
        
        public string Image { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public DateTime Date { get; set; }
      
    }
}
