using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Interface
{
  public  interface IRoleRepository
    {
        //בממשק הברירת מחדל שלו היא public לממשק לא מגדירים הרשאת גישה היא
         List<Role> GetAll();

         Role GetById(int id);

         Role Add(int id,string name,string description);

         Role Update(Role r);

         void Delete(int id);
    }
}
