using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class NoticeBoard:BaseEntity
    {
        [Required(ErrorMessage = "Date Boş keçilə bilməz")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }
    }
}
