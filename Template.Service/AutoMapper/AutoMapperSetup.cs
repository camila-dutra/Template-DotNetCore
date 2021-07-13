using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Template.Domain.Entities;
using Template.Service.DTOs;

namespace Template.Service.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            CreateMap<UserDTO, User>().ReverseMap();

        }
    }
}
