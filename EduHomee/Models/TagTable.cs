using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class TagTable:BaseEntity
    {
        [Required(ErrorMessage = "Name Boş keçilə bilməz")]
        public string Name { get; set; }
    }
}
