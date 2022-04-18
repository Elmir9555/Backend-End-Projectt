using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace EduHomee.ViewModels.Admin
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
