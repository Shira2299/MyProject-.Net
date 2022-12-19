using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
  public  interface IClaimRepository
    {
        Task<List<Claim>> GetAllAsync();

        Task<Claim> GetByIdAsync(int id);

        Task<Claim> AddAsync(Role role, Permission permission, Epolicy policy);

        Task<Claim> UpdateAsync(Claim c);

        Task DeleteAsync(int id);
    }
}
