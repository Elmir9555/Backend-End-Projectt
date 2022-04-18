using System;
using Microsoft.AspNetCore.Identity;

namespace EduHomee.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActiveted { get; set; }
    }
}
