using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PermmisionRepository : IPermissionRepository
    {
        private readonly IContex _context;

        public PermmisionRepository(IContex context)
        {
            _context = context;
        }
        public async Task<Permission> AddAsync(string name, string description)
        {
            Permission newPermission = new Permission { Name = name, Description = description };
            var permission=_context.Permissions.Add(newPermission);
            await _context.SaveChangesAsync();  
            return permission.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var deletePermmision = await GetByIdAsync(id);
            if (deletePermmision != null)
            {
                _context.Permissions.Remove(deletePermmision);
                await _context.SaveChangesAsync();
            }
        }      
        public async Task<Permission> GetByIdAsync(int id)
        {
            return await _context.Permissions.FindAsync(id);
        }

        public async Task<Permission> UpdateAsync(Permission p)
        {
            var updatePermission = await _context.Permissions.FindAsync(p.Id);
            updatePermission.Name = p.Name;
            updatePermission.Description = p.Description;
            return updatePermission;
        }

        public async Task<List<Permission>> GetAllAsync()
        {
            return await _context.Permissions.ToListAsync();
        }
    }
}
