using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContex _contex;
        public async Task<User> AddAsync(string name, int password)
        {
            User newUser=new User { Name=name, Password=password};
            var use=_contex.Users.Add(newUser);
            await _contex.SaveChangesAsync();   
            return use.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteUser=await GetByIdAsync(id);
            if(deleteUser!=null)
            {
                _contex.Users.Remove(deleteUser);
                await _contex.SaveChangesAsync();
            }
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _contex.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)//there is error 500 in run time????
        {
            return await _contex.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User u)
        {
            var use = _contex.Users.Update(u);
            await _contex.SaveChangesAsync();
            return use.Entity;      
        }
    }
}
