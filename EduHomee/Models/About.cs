using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class About: BaseEntity
    {
        [Required(ErrorMessage ="Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }
       
    }
}
