using System;
using System.Collections.Generic;

namespace EduHomee.Models
{
    public class Event:BaseEntity
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateTime Date { get; set; }

        //Realtion Property

        public List<EventTeacher> EventTeachers { get; set; }
    }
}
