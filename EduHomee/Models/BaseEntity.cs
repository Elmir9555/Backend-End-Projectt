using System;
namespace EduHomee.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string IsDelete { get; set; }
    }
}
