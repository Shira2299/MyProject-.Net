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
            // Role role = new Role {Id=1, Name="admin",Description="admintor" };
            // Console.WriteLine($"Role= Id:{role.Id}, Name:{role.Name}, Descreption:{role.Description}");
            // Console.WriteLine();
            // Permission p=new Permission { Id=2, Name="Chaim",Descreption="Chaimke"};
            // Console.WriteLine($"Permission= Id:{p.Id},Name:{p.Name},Descreption:{p.Description}");
            // Console.WriteLine();
            // claim c=new claim { Id=1,PermissionId=2,RoleId=3};
            //Console.WriteLine($"claim= Id:{c.Id},PermissionId:{c.PermissionId},RoleId:{c.RoleId} ");

            var mockContext = new MockContext();
            //create repository and send the MockContext to the ctor
            var roleRepository = new RoleRepository(mockContext);
            var permmisionRepository=new PermmisionRepository(mockContext);
            var claimRepository=new ClaimRepository(mockContext);
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
                                Console.WriteLine("Enter id,name,description");
                                roleRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                break;
                            case "delete":
                                Console.WriteLine("Press Id for deleted");
                                roleRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "GetAll":
                                roleRepository.GetAll();
                                break;
                            case "GetById":
                                Console.WriteLine("Press Id");
                                roleRepository.GetById(int.Parse(Console.ReadLine()));
                                break;
                            case "Update":
                                Console.WriteLine("Enter Id");
                                var role = roleRepository.GetById(int.Parse(Console.ReadLine()));
                                role.Name = "Administrator";
                                roleRepository.Update(role);
                                break;
                        }
                        break;
                    case "p":
                        Console.WriteLine("Enter action");
                        str = Console.ReadLine();
                        switch(str)
                        {
                            case "add":
                                Console.WriteLine("Enter id,name,description");
                                permmisionRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                break;
                            case "delete":
                                Console.WriteLine("Press Id for deleted");
                                permmisionRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "GetAll":
                                permmisionRepository.GetAll();
                                break;
                            case "GetById":
                                Console.WriteLine("Press Id");
                                permmisionRepository.GetById(int.Parse(Console.ReadLine()));
                                break;
                            case "Update":
                                Console.WriteLine("Enter Id");
                                var role = roleRepository.GetById(int.Parse(Console.ReadLine()));
                                role.Name = "Administrator";
                                roleRepository.Update(role);
                                break;

                        }
                        break;
                    case "c":
                        Console.WriteLine("Enter action");
                        str = Console.ReadLine();
                        switch(str)
                        {
                            case "add":
                                Console.WriteLine("Enter int int int");
                                claimRepository.Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                                break;
                            case "GetById":
                                Console.WriteLine("Prees Id");
                                claimRepository.GetById(int.Parse(Console.ReadLine()));
                                break;
                            case "GetAll":
                                claimRepository.GetAll();
                                break;
                            case "delete":
                                Console.WriteLine("Press Id for deleted");
                                claimRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "Update":
                                Console.WriteLine("Enter Id");
                                var role = roleRepository.GetById(int.Parse(Console.ReadLine()));
                                role.Name = "Administrator";
                                roleRepository.Update(role);
                                break;
                        }
                       break ;
                }

            } while (obg != "exit");
        }
    }
}
