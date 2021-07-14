using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Service.DTOs
{
    public class UserAuthenticateRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
