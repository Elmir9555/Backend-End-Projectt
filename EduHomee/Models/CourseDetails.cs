using System;
namespace EduHomee.Models
{
    public class CourseDetails:BaseEntity
    {
        public string About { get; set; }
        public string Certificate { get; set; }
        public string HowToApply { get; set; }
        public int CourseCount { get; set; }


        public int CourseId { get; set; }

        //Relation Property

        public Course Course { get; set; }
    }
}
