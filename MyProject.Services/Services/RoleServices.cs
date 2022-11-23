using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interface;
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

        public async Task<RoleDTO> AddAsync(string name, string description)
        {
           return  _mapper.Map<RoleDTO>(await _roleRepository.AddAsync(name, description));
        }

        public async Task DeleteAsync(int id)
        {
           await _roleRepository.DeleteAsync(id);
        }

        public async Task<RoleDTO> GetByIdAsync(int id)
        {
            var role = await _roleRepository.GetByIdAsync(id);
            return  _mapper.Map<RoleDTO>( role);                  
        }

        public async Task<List<RoleDTO>> GetListAsync()
        {
            return _mapper.Map<List<RoleDTO>>(await _roleRepository.GetAllAsync());
        }

        public async Task<RoleDTO> UpdateAsync(RoleDTO r)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.UpdateAsync(_mapper.Map<Role>(r)));
        }
    }
}
