using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class PermissionServices : IPermmisionServices
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionServices(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository=permissionRepository;
            _mapper=mapper;
        }
        public async Task<PermissionDTO> AddAsync(string name, string description)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.AddAsync(name, description));
        }

        public async Task DeleteAsync(int id)
        {
          await  _permissionRepository.DeleteAsync(id);
        }

        public async Task<PermissionDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.GetByIdAsync(id));
        }

        public async Task<List<PermissionDTO>> GetListAsync()
        {
            return _mapper.Map<List<PermissionDTO>>(await _permissionRepository.GetAllAsync());
        }

        public async Task<PermissionDTO> UpdateAsync(PermissionDTO p)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.UpdateAsync(_mapper.Map<Permission>(p)));
        }
    }
}
