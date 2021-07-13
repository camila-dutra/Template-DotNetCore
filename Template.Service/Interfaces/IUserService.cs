using System;
using System.Collections.Generic;
using System.Text;
using Template.Service.DTOs;

namespace Template.Service.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> Get();
    }
}
