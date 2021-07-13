using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Template.Domain.Entities;
using Template.Infrastructure.Interfaces;
using Template.Service.DTOs;
using Template.Service.Interfaces;

namespace Template.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public List<UserDTO> Get()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            IEnumerable<User> users = this.userRepository.GetAll();

            usersDTO = mapper.Map<List<UserDTO>>(users);

            return usersDTO;
        }

        public bool Post(UserDTO user)
        {
            User us = mapper.Map<User>(user);

            this.userRepository.Create(us);

            return true;
        }
    }
}
