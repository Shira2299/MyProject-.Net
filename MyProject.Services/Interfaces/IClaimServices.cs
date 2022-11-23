using MyProject.Common.DTOs;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimServices
    {
        Task<List<ClaimDTO>> GetListAsync();

        Task<ClaimDTO> GetByIdAsync(int id);

        Task<ClaimDTO> AddAsync(Role role, Permission permission, Epolicy policy);

        Task<ClaimDTO> UpdateAsync(ClaimDTO c);

        Task DeleteAsync(int id);
    }
}
