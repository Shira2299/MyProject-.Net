using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositoties;
using MyProject.Repositoties.Interface;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class RoleServices : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleServices(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public RoleDTO Add(int id, string name, string description)
        {
           return  _mapper.Map<RoleDTO>(_roleRepository.Add(id, name, description));
        }

        public void Delete(int id)
        {
           _roleRepository.Delete(id);
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));
            //or
            //var role = _roleRepository.GetById(id);
            // return _mapper.Map<RoleDTO>(role);
        }

        public List<RoleDTO> GetList()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());
        }

        public RoleDTO Update(RoleDTO r)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Update(_mapper.Map<Role>(r)));
        }
    }
}
