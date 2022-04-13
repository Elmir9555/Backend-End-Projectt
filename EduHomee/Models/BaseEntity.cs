using System;
namespace EduHomee.Models
{
    public abstract class BaseEntity
    {
        
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;

     
    }
}
