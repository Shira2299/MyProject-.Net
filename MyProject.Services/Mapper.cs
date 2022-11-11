using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<RoleDTO, Role>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
        }
    }
}
