﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AutoMapper;
using Moq;
using Template.Infrastructure.Interfaces;
using Template.Service.DTOs;
using Template.Service.Services;
using Xunit;


namespace Template.Tests.Services
{
    public class UserServiceTests
    {
        private UserService userService;

        public UserServiceTests()
        {
            userService = new UserService(new Mock<IUserRepository>().Object, new Mock<IMapper>().Object);
        }

        #region ValidatingSendingID

        [Fact]
        public void Post_SendingValidID()
        {
            ////pode retornar Assert.Throws
            //Assert.Throws<Exception>( () => userService.Post(new UserDTO { Id = Guid.NewGuid() })); // esse result deveria retornar falso ou uma Exception pq nao pode ter um id em um insert

            //verificando a mensagem
            var exception = Assert.Throws<Exception>(() => userService.Post(new UserDTO { Id = Guid.NewGuid() }));
            Assert.Equal("UserId must be empty", exception.Message);
        }

        [Fact]
        public void GetById_SendingEmptyGuid()
        {
            var exception = Assert.Throws<Exception>(() => userService.GetById(""));
            Assert.Equal("UserID is not valid", exception.Message);
        }

        [Fact]
        public void Put_SendingEmptyGuid()
        {
            var exception = Assert.Throws<Exception>(() => userService.Put(new UserDTO()));
            Assert.Equal("ID is invalid", exception.Message);
        }

        [Fact]
        public void Delete_SendingEmptyGuid()
        {
            var exception = Assert.Throws<Exception>(() => userService.Delete(""));
            Assert.Equal("UserID is not valid", exception.Message);
        }

        [Fact]
        public void Authenticate_SendingEmptyGuid()
        {
            var exception = Assert.Throws<Exception>(() => userService.Authenticate(new UserAuthenticateRequestDTO()));
            Assert.Equal("Email/Password are required.", exception.Message);
        }
        #endregion

        #region ValidatingCorrectObject
        [Fact]
        public void Post_SendingValidObject()
        {
            var result = userService.Post(new UserDTO { Name = "Camila Martins", Email = "cmartinsdutra@gmail.com"});
            Assert.True(result);
        }

        #endregion

        #region ValidatingRequiredFields
        [Fact]
        public void Post_SendingInalidObject()
        {
            var exception = Assert.Throws<ValidationException>(() => userService.Post(new UserDTO { Name = "Camila Martins" }));
            Assert.Equal("The Email field is required.", exception.Message);
        }

        #endregion

    }
}
