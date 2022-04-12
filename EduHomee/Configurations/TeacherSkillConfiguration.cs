using System;
using EduHomee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduHomee.Configurations
{
    public class TeacherSkillConfiguration : IEntityTypeConfiguration<TeacherSkill>
    {
        public void Configure(EntityTypeBuilder<TeacherSkill> builder)
        {
            builder.HasIndex(x => new
            {
                x.SkillId,
                x.TeacherId
            }).IsUnique();

            builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherSkills).HasForeignKey(x => x.TeacherId);
            builder.HasOne(x => x.Skill).WithMany(x => x.TeacherSkills).HasForeignKey(x => x.SkillId);
        }
    }
}
