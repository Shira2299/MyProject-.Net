﻿using MyProject.Repositoties.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var newRole = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(newRole);
            return newRole;
        }

        public void Delete(int id)
        {
            var deleteRole = _context.Roles.Find(id);
            if (deleteRole != null)
                _context.Roles.Remove(deleteRole);
        }     

        public Role GetById(int id)
        {
           // return _context.Roles.First(r => r.Id == id);
            return _context.Roles.Find(id);
        }

        public Role Update(Role r)
        {
            //var newRole = GetById(role.id);לשאול מה עדיף
            //check if is possible to use with First
            var updateRole = _context.Roles.First(r => r.Id == r.Id);
            updateRole.Name = r.Name;
            updateRole.Description = r.Description;
            return updateRole;
        }
       
        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }
    }
}
