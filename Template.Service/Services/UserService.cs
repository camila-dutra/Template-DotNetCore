using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using AutoMapper;
using Template.Domain.Entities;
using Template.Infrastructure.Auth;
using Template.Infrastructure.Interfaces;
using Template.Service.DTOs;
using Template.Service.Interfaces;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

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
            if (user.Id != Guid.Empty)
                throw new Exception("UserId must be empty");

            Validator.ValidateObject(user, new ValidationContext(user), true);

            User _user = mapper.Map<User>(user);

            this.userRepository.Create(_user);

            return true;
        }

        public UserDTO GetById(string id)
        {
            if(!Guid.TryParse(id, out Guid userId))
                throw new Exception("UserID is not valid");

            List<User> users = this.userRepository.GetAll().ToList();
            User _user = users.Find(x => x.Id == userId && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");



            return mapper.Map<UserDTO>(_user);
        }

        public bool Put(UserDTO user)
        {
            if (user.Id == Guid.Empty)
                throw new Exception("ID is invalid");

            List<User> users = this.userRepository.GetAll().ToList();
            User _user = users.Find(x => x.Id == user.Id && !x.IsDeleted);

            if (_user == null)
                throw new Exception("User not found");

            _user = mapper.Map<User>(user);

            this.userRepository.Update(_user);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid userId))
                throw new Exception("UserID is not valid");

            List<User> users = this.userRepository.GetAll().ToList();
            User _user = users.Find(x => x.Id == userId && !x.IsDeleted);
            if (_user == null)
                throw new Exception("User not found");

            _user.IsDeleted = true;
            this.userRepository.Delete(_user);

            return true;
        }

        public UserAuthenticateResponseDTO Authenticate(UserAuthenticateRequestDTO user)
        {
            if (string.IsNullOrEmpty(user.Email))
                throw new Exception("Email/Password are required.");

            List<User> users = this.userRepository.GetAll().ToList();
            User _user = users.Find(x => !x.IsDeleted && x.Email.ToUpper() == user.Email.ToUpper());

            if (_user == null)
                throw new Exception("User not found");

            return new UserAuthenticateResponseDTO(mapper.Map<UserDTO>(_user), TokenService.GenerateToken(_user));
        }

    }
}
