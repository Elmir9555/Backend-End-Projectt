using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Service:BaseEntity
    {
        [Required(ErrorMessage = "Title Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }
    }
}
