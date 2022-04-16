using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Social:BaseEntity
    {
        [Required(ErrorMessage = "Icon Boş keçilə bilməz")]
        public string Icon { get; set; }
    }
}
