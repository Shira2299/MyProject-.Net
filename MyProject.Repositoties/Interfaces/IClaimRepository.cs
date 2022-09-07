using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Interfaces
{
  public  interface IClaimRepository
    {
        public claim[] GetAll();

        public claim GetById(int id);

        public claim Add(int id, int RoleId, int PermissionId);

        public claim Update(claim c);

        public void Delete(int id);
    }
}
