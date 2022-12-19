using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServices(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(string name, int password)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(name, password));
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var use = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(use);
        }

        public async Task<List<UserDTO>> GetListAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }    

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
