using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContex _contex;
        public ClaimRepository(IContex contex)
        {
                _contex = contex;
        }
        public claim Add(int id, int RoleId, int PermissionId)
        {
            var newClaim=new claim { Id=id, RoleId=RoleId, PermissionId=PermissionId };
            _contex.Claims.Add(newClaim);
            return newClaim;
        }

        public void Delete(int id)
        {
            var deleteClaim = _contex.Claims.Find(r => r.Id == id);
            if(deleteClaim != null)
                _contex.Claims.Remove(deleteClaim);
        }

        public List<claim> GetAll()
        {
            return _contex.Claims;
        }

        public claim GetById(int id)
        {
            return _contex.Claims.Find(r=>r.Id==id);
        }

        public claim Update(claim c)
        {
            var updateClaim = GetById(c.Id);
            updateClaim.RoleId = c.RoleId;
            updateClaim.PermissionId = c.PermissionId;
            return updateClaim;
        }

       
    }
}
