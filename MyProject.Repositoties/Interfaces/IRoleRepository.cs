using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interface
{
  public  interface IRoleRepository
    {
        //בממשק הברירת מחדל שלו היא public לממשק לא מגדירים הרשאת גישה היא
         Task<List<Role>> GetAllAsync();

         Task<Role> GetByIdAsync(int id);

         Task<Role> AddAsync(string name,string description);

         Task<Role> UpdateAsync(Role r);

         Task DeleteAsync(int id);
    }
}
