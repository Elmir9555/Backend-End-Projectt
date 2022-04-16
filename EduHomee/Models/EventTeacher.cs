using System;
namespace EduHomee.Models
{
    public class EventTeacher:BaseEntity
    {

        //Realtion Property 
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
