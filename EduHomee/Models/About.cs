using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace EduHomee.Models
{
    public class About: BaseEntity
    {
        [Required(ErrorMessage ="Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile photo { get; set; }

    }
}
