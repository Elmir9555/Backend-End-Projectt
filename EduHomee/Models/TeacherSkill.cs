using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class TeacherSkill:BaseEntity
    {

        [Required(ErrorMessage = "Degree Boş keçilə bilməz")]
        public int Degree { get; set; }
        //Relation Property
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
