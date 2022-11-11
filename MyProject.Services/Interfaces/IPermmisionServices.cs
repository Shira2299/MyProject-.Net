using MyProject.Common.DTOs;
using MyProject.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermmisionServices
    {
         List<PermissionDTO> GetAll();

        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name, string description);

        PermissionDTO Update(PermissionDTO r);

         void Delete(int id);
    }
}
