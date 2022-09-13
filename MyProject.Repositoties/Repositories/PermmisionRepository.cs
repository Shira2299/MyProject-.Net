using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class PermmisionRepository : IPermissionRepository
    {
        private readonly IContex _context;

        public PermmisionRepository(IContex context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string descreption)
        {
            var newPermission = new Permission { Id = id, Name = name, Descreption = descreption };
            _context.Permissions.Add(newPermission);
            return newPermission;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }      
        public Permission GetById(int id)
        {
            return _context.Permissions.Find(r => r.Id == id);
        }

        public Permission Update(Permission r)
        {
            throw new NotImplementedException();
        }

        List<Permission> IPermissionRepository.GetAll()
        {
            return _context.Permissions;
        }
    }
}
