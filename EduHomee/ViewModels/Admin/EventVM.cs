using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace EduHomee.ViewModels.Admin
{
    public class EventVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string Desc { get; set; }
        public string EndDate { get; set; }
        public DateTime Date { get; set; }
        public List<IFormFile> Photos { get; set; }

    }
}
