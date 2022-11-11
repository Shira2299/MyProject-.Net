using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Interfaces
{
  public  interface IPermissionRepository
    {
         List<Permission> GetAll();

         Permission GetById(int id);

         Permission Add(int id, string name, string description);

         Permission Update(Permission r);

         void Delete(int id);
    }
}
