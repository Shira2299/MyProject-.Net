using MyProject.Repositoties;
using System;

namespace MyProject.ConsoleUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Role role = new Role {Id=1, Name="admin",Descreption="admintor" };
            Console.WriteLine($"Role= Id:{role.Id}, Name:{role.Name}, Descreption:{role.Descreption}");
            Console.WriteLine();
            Permission p=new Permission { Id=2, Name="Chaim",Descreption="Chaimke"};
            Console.WriteLine($"Permission= Id:{p.Id},Name:{p.Name},Descreption:{p.Descreption}");
            Console.WriteLine();
            claim c=new claim { Id=1,PermissionId=2,RoleId=3};
           Console.WriteLine($"claim= Id:{c.Id},PermissionId:{c.PermissionId},RoleId:{c.RoleId} ");
        }
    }
}
