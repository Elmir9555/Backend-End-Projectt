using System;
using System.Collections.Generic;

namespace EduHomee.Models
{
    public class Skill:BaseEntity
    {
        public string Name { get; set; }

        //Relation Property

        public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
