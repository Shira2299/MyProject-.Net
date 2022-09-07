using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        public claim Add(int id, int RoleId, int PermissionId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public claim[] GetAll()
        {
            throw new NotImplementedException();
        }

        public claim GetById(int id)
        {
            throw new NotImplementedException();
        }

        public claim Update(claim c)
        {
            throw new NotImplementedException();
        }
    }
}
