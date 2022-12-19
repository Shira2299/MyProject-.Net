using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);

        Task<User> AddAsync(string name, int password);

        Task<User> UpdateAsync(User r);

        Task DeleteAsync(int id);
    }
}
