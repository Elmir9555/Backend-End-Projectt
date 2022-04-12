using System;
namespace EduHomee.Models
{
    public class TeacherSkill:BaseEntity
    {
        public int TeacherId { get; set; }
        public int SkillId { get; set; }


        //Relation Property

        public Teacher Teacher { get; set; }
        public Skill Skill { get; set; }
    }
}
