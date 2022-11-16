using MyProject.Repositoties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Permission Add(int id, string name, string description)
        {
            var newPermission = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(newPermission);
            return newPermission;
        }

        public void Delete(int id)
        {
            var deletePermission = _context.Permissions.Find(id);
            if (deletePermission != null)
                _context.Permissions.Remove(deletePermission);
        }      
        public Permission GetById(int id)
        {
            return _context.Permissions.Find(id);
        }

        public Permission Update(Permission r)
        {
            var updatePermission = _context.Permissions.First(r => r.Id == r.Id);
            updatePermission.Name = r.Name;
            updatePermission.Description = r.Description;
            return updatePermission;
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions.ToList();
        }
    }
}
