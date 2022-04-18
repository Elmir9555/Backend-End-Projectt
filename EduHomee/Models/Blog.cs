using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

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
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
