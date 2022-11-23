using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContex _context;

        public RoleRepository(IContex context)
        {
            _context = context;
        }
        public async Task<Role> AddAsync(string name, string description)
        {
            var newRole = new Role { Name = name, Description = description };
            await  _context.Roles.AddAsync(newRole);
            return newRole;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteRole =await GetByIdAsync(id);
            if(deleteRole != null)
            {
                _context.Roles.Remove(deleteRole);
                await _context.SaveChangesAsync();
            }       
        }
     
        public async Task<Role> GetByIdAsync(int id)
        {
            // return await _context.Roles.FirstAsync(r => r.Id == id);
            return await _context.Roles.FindAsync(id);
        }

        public async Task<Role> UpdateAsync(Role r)
        {

            var update = _context.Roles.Update(r);
            await _context.SaveChangesAsync();
            return update.Entity;
            //var updateRole = await _context.Roles.FindAsync(r.Id);
            //updateRole.Name = r.Name;
            //updateRole.Description = r.Description;
            //return updateRole;
        }

        public async Task<List<Role>> GetAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }
       

     
    }
}
