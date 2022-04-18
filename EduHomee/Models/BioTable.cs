using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class BioTable:BaseEntity
    {
        [Required(ErrorMessage = "PhoneNumber Boş keçilə bilməz")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Adress Boş keçilə bilməz")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Email Boş keçilə bilməz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "SiteLink Boş keçilə bilməz")]
        public string SiteLink { get; set; }
    }
}
