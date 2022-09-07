using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class PermmisionRepository : IPermissionRepository
    {
        public Permission Add(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Permission[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Permission GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Permission Update(Permission r)
        {
            throw new NotImplementedException();
        }
    }
}
