using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IUserServices
    {
        Task<List<UserDTO>> GetListAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserDTO> AddAsync(string name, int password);

        Task<UserDTO> UpdateAsync(UserDTO user);

        Task DeleteAsync(int id);
    }
}
