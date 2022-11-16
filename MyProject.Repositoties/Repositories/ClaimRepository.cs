using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Claim Add(int id, int RoleId, int PermissionId)
        {
            var newClaim=new Claim { Id=id/*, RoleId=RoleId, PermissionId=PermissionId*/ };
            _contex.Claims.Add(newClaim);
            return newClaim;
        }

        public void Delete(int id)
        {
            var deleteClaim = _contex.Claims.Find(id);
            if(deleteClaim != null)
                _contex.Claims.Remove(deleteClaim);
        }

        public List<Claim> GetAll()
        {
            return _contex.Claims.ToList();
        }

        public Claim GetById(int id)
        {
            return _contex.Claims.Find(id);
        }

        public Claim Update(Claim c)
        {
            var updateClaim = GetById(c.Id);
            updateClaim.RoleId = c.RoleId;
            updateClaim.PermissionId = c.PermissionId;
            return updateClaim;
        }

       
    }
}
