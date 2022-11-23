using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContex _contex;
        public ClaimRepository(IContex contex)
        {
                _contex = contex;
        }

        public async Task<Claim> AddAsync(Role role, Permission permission, Epolicy policy)
        {
            Claim newClaim = new Claim { /*Role=role,Permission=permission ,*/Policy=policy };
            await _contex.Claims.AddAsync(newClaim);
            return newClaim;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteClaim = await GetByIdAsync(id);
            if (deleteClaim != null)
            {
                _contex.Claims.Remove(deleteClaim);
                await _contex.SaveChangesAsync();
            }
        }

        public async Task<List<Claim>> GetAllAsync()
        {
            return await _contex.Claims.ToListAsync();
        }

        public async Task<Claim> GetByIdAsync(int id)
        {
            return await _contex.Claims.FindAsync(id);
        }

        public async Task<Claim> UpdateAsync(Claim c)
        {
            var updateClaim = await _contex.Claims.FindAsync(c.Id);
            updateClaim.Role = c.Role;
            updateClaim.Permission = c.Permission;
            return updateClaim;      
        }

       
    }
}
