using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace EduHomee.ViewModels.Admin
{
    public class TestimonialVM
    {
        public string Fullname { get; set; }
        public string Description { get; set; }
        public string Work { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
