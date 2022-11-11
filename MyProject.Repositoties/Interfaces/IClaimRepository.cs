using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositoties.Interfaces
{
  public  interface IClaimRepository
    {
         List<claim> GetAll();

         claim GetById(int id);

         claim Add(int id, int RoleId, int PermissionId);

         claim Update(claim c);

         void Delete(int id);
    }
}
