using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Event:BaseEntity
    {
        [Required(ErrorMessage = "Title Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Location Boş keçilə bilməz")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }

        public string Image { get; set; }
        [Required(ErrorMessage = "StartDate Boş keçilə bilməz")]
        public string StartDate { get; set; }
        [Required(ErrorMessage = "EndDate Boş keçilə bilməz")]
        public string EndDate { get; set; }
        [Required(ErrorMessage = "Date Boş keçilə bilməz")]
        public DateTime Date { get; set; }

        //Realtion Property

        public List<EventTeacher> EventTeachers { get; set; }
    }
}
