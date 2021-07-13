using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;
using Template.Infrastructure.Interfaces;
using Template.Service.DTOs;
using Template.Service.Interfaces;

namespace Template.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<UserDTO> Get()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            IEnumerable<User> users = this.userRepository.GetAll();

            foreach (var item in users)
            {
                usersDTO.Add(new UserDTO{ Id = item.Id, Name = item.Name, Email = item.Email});
            }

            return usersDTO;
        }
    }
}
