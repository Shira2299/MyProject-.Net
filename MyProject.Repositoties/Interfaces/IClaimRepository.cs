using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositoties.Interfaces
{
  public  interface IClaimRepository
    {
         List<Claim> GetAll();

         Claim GetById(int id);

         Claim Add(int id, int RoleId, int PermissionId);

         Claim Update(Claim c);

         void Delete(int id);
    }
}
