using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace EduHomee.ViewModels.Admin
{
    public class BlogVM
    {
    
        public string TeacherName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
