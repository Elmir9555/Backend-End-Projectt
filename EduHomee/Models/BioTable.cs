using System;
namespace EduHomee.Models
{
    public class BioTable:BaseEntity
    {
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string SiteLink { get; set; }
    }
}
