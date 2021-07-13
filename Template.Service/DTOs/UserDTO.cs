using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Service.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
