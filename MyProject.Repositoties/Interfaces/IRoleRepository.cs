using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Interface
{
  public  interface IRoleRepository
    {
        public Role[] GetAll();

        public Role GetById(int id);

        public Role Add(int id,string name,string description);

        public Role Update(Role r);

        public void Delete(int id);
    }
}
