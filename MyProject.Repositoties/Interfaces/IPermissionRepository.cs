using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
  public  interface IPermissionRepository
    {
        Task<List<Permission>> GetAllAsync();

        Task<Permission> GetByIdAsync(int id);

        Task<Permission> AddAsync(string name, string description);

        Task<Permission> UpdateAsync(Permission r);

        Task DeleteAsync(int id);
    }
}
