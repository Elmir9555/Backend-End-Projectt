using System;
namespace EduHomee.Models
{
    public class CourseFeatures:BaseEntity
    {
        public string Start { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string Language { get; set; }
        public string SkillLevel { get; set; }
        public string Students { get; set; }
        public string Assesments { get; set; }
        public string CourseFee { get; set; }

        public int CourseId { get; set; }
        //Relation Property

        public Course Course { get; set; }
    }
}
