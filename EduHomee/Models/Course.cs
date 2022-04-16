using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Course:BaseEntity
    {
        [Required(ErrorMessage = "Title Boş keçilə bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description Boş keçilə bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }


        //Relation Property
        public int CourseDetailId { get; set; }
        public CourseDetails CourseDetails { get; set; }
        public int CourseFeatureId { get; set; }
        public CourseFeatures CourseFeatures { get; set; }
    }
}
