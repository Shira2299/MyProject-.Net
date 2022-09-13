using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContex _context;

        public ClaimRepository(IContex context)
        {
            _context = context;
        }
        public claim Add(int id, int RoleId, int PermissionId)
        {
            var newClaim = new claim { Id = id, RoleId = RoleId, PermissionId = PermissionId };
            _context.Claims.Add(newClaim);
            return newClaim;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }      

        public claim GetById(int id)
        {
            return _context.Claims.Find(r => r.Id == id);
        }

        public claim Update(claim c)
        {
            throw new NotImplementedException();
        }

        List<claim> IClaimRepository.GetAll()
        {
            return _context.Claims;
        }
    }
}
