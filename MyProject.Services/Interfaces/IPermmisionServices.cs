using MyProject.Common.DTOs;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermmisionServices
    {
        Task<List<PermissionDTO>> GetListAsync();

        Task<PermissionDTO> GetByIdAsync(int id);

        Task<PermissionDTO> AddAsync(string name, string description);

        Task<PermissionDTO> UpdateAsync(PermissionDTO p);

        Task DeleteAsync(int id);
    }
}
