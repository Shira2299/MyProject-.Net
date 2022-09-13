using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Interfaces
{
  public  interface IPermissionRepository
    {
        public List<Permission> GetAll();

        public Permission GetById(int id);

        public Permission Add(int id, string name, string description);

        public Permission Update(Permission r);

        public void Delete(int id);
    }
}
