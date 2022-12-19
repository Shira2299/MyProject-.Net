using MyProject.Common.DTOs;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        //why RoleDTO and not Role?
        Task<List<RoleDTO>> GetListAsync();

        Task<RoleDTO> GetByIdAsync(int id);

        Task<RoleDTO> AddAsync(string name, string description);

        Task<RoleDTO> UpdateAsync(RoleDTO r);

        Task DeleteAsync(int id);
    }
}
