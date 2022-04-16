using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class BioTable:BaseEntity
    {
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Boş keçilə bilməz")]
        public string SiteLink { get; set; }
    }
}
