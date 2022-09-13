using MyProject.Repositoties.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContex _context;

        public RoleRepository(IContex context)
        {
            _context = context;
        }
        public Role Add(int id, string name, string description)
        {
            var newRole = new Role { Id = id, Name = name, Descreption = description };
            _context.Roles.Add(newRole);
            return newRole;
        }

        public void Delete(int id)
        {
            var deleteRole = _context.Roles.Find(r => r.Id == id);
            if (deleteRole != null)
                _context.Roles.Remove(deleteRole);
        }     

        public Role GetById(int id)
        {
            return _context.Roles.Find(r => r.Id == id);
        }

        public Role Update(Role r)
        {
            //var newRole = GetById(role.id);לשאול מה עדיף
            var updateRole = _context.Roles.Find(r => r.Id == r.Id);
            updateRole.Name = r.Name;
            updateRole.Descreption = r.Descreption;
            return updateRole;
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }
    }
}
