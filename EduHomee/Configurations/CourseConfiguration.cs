using System;
using EduHomee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduHomee.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(x => x.CourseDetails).WithOne(x => x.Course).HasForeignKey<CourseDetails>(x => x.CourseId);
            builder.HasOne(x => x.CourseFeatures).WithOne(x => x.Course).HasForeignKey<CourseFeatures>(x => x.CourseId);
        }
    }
}
