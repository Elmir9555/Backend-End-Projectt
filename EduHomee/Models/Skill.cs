using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class Skill:BaseEntity
    {
        [Required(ErrorMessage = "Name Boş keçilə bilməz")]
        public string Name { get; set; }
        

        //Relation Property

        public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
