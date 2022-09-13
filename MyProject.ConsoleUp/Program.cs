using MyProject.Mock;
using MyProject.Repositoties;
using MyProject.Repositoties.Repositories;
using System;

namespace MyProject.ConsoleUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Role role = new Role {Id=1, Name="admin",Descreption="admintor" };
            // Console.WriteLine($"Role= Id:{role.Id}, Name:{role.Name}, Descreption:{role.Descreption}");
            // Console.WriteLine();
            // Permission p=new Permission { Id=2, Name="Chaim",Descreption="Chaimke"};
            // Console.WriteLine($"Permission= Id:{p.Id},Name:{p.Name},Descreption:{p.Descreption}");
            // Console.WriteLine();
            // claim c=new claim { Id=1,PermissionId=2,RoleId=3};
            //Console.WriteLine($"claim= Id:{c.Id},PermissionId:{c.PermissionId},RoleId:{c.RoleId} ");

            var mockContext = new MockContext();
            //create repository and send the MockContext to the ctor
            var roleRepository = new RoleRepository(mockContext);
            string obg;
            string str;
            do
            {
                Console.WriteLine("Enter object");
                obg = Console.ReadLine();
                switch(obg)
                {
                    case "r":
                        Console.WriteLine("Enter action");
                        str = Console.ReadLine();
                        switch(str)
                        {
                            case "add":
                                roleRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                break;
                            case "delete":
                                roleRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                                
                        }
                }
              
            } while (obg != "exit");
        }
    }
}
