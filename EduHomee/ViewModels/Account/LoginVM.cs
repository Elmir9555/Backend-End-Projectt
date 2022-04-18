using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomee.Models
{
    public class LoginVM
    {

        [Required]
        public string UserNameOrEmail { get; set; }

        [Required, DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
