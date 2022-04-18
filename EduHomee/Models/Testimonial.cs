using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EduHomee.Models
{
    public class Testimonial:BaseEntity
    {
        [Required(ErrorMessage = "FullName Boş keçilə bilməz")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Work Boş keçilə bilməz")]
        public string Work { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
