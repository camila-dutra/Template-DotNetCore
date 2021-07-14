using System;
using System.Collections.Generic;
using System.Text;
using Template.Service.DTOs;

namespace Template.Service.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> Get();
        bool Post(UserDTO user); 
        UserDTO GetById(string id);
        bool Put(UserDTO user);
        bool Delete(string id);
        UserAuthenticateResponseDTO Authenticate(UserAuthenticateRequestDTO user);
    }
}
