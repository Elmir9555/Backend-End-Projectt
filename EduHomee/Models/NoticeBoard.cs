using System;
namespace EduHomee.Models
{
    public class NoticeBoard:BaseEntity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
