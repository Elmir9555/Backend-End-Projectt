using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EduHomee.Models
{
    public class Slider:BaseEntity
    {
        [Required(ErrorMessage = "Title Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
