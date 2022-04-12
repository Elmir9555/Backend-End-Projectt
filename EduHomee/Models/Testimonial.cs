using System;
namespace EduHomee.Models
{
    public class Testimonial:BaseEntity
    {
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Work { get; set; }
    }
}
