using System;
using EduHomee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduHomee.Configurations
{
    public class EventTeacherConfiguration : IEntityTypeConfiguration<EventTeacher>
    {
        public void Configure(EntityTypeBuilder<EventTeacher> builder)
        {
            builder.HasIndex(x => new
            {
                x.EventId,
                x.TeacherId
            }).IsUnique();


            builder.HasOne(x => x.Teacher).WithMany(x => x.EventTeachers).HasForeignKey(x => x.TeacherId);
            builder.HasOne(x => x.Event).WithMany(x => x.EventTeachers).HasForeignKey(x => x.EventId);
        }
    }
}
