using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Service.DTOs
{
    public class UserAuthenticateResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
        public UserAuthenticateResponseDTO(UserDTO user, string token)
        {
            this.User = user;
            this.Token = token;
        }
    }
}
