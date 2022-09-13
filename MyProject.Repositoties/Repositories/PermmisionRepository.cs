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
            var deletePermission = _context.Permissions.Find(r => r.Id == id);
            if (deletePermission != null)
                _context.Permissions.Remove(deletePermission);
        }      
        public Permission GetById(int id)
        {
            return _context.Permissions.Find(r => r.Id == id);
        }

        public Permission Update(Permission r)
        {
            var updatePermission = _context.Permissions.Find(r => r.Id == r.Id);
            updatePermission.Name = r.Name;
            updatePermission.Descreption = r.Descreption;
            return updatePermission;
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }
    }
}
