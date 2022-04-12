using System;
namespace EduHomee.Models
{
    public class Course:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        //Relation Property

        public CourseDetails CourseDetails { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
    }
}
