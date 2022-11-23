using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ClaimServices : IClaimServices
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimServices(IClaimRepository claimRepository,IMapper mapper)
        {
            _claimRepository=claimRepository;
            _mapper=mapper;
        }
        public async Task<ClaimDTO> AddAsync(Role role, Permission permission,Epolicy policy)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.AddAsync(role, permission, policy));
        }

        public async Task DeleteAsync(int id)
        {
           await _claimRepository.DeleteAsync(id);
        }

        public async Task<ClaimDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.GetByIdAsync(id));
        }

        public async Task<List<ClaimDTO>> GetListAsync()
        {
            return _mapper.Map<List<ClaimDTO>>(await _claimRepository.GetAllAsync());
        }

      public async Task<ClaimDTO> UpdateAsync(ClaimDTO c)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.UpdateAsync(_mapper.Map<Repositories.Claim>(c)));
        }
    }
}
