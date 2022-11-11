using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositoties;
using MyProject.Repositoties.Interfaces;
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
        public ClaimDTO Add(int id, int RoleId, int PermissionId)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Add(id, RoleId, PermissionId));
        }

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }
        //לבדוק אם זה נכון גם בצורה הזאת
      //  public ClaimDTO Update(ClaimDTO c) => _mapper.Map<ClaimDTO>(_claimRepository.Update(_mapper.Map<Claim>(c)));
      public ClaimDTO Update(ClaimDTO c)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(_mapper.Map<claim>(c)));
        }
    }
}
