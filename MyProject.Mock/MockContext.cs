using MyProject.Repositoties;
using MyProject.Repositoties.Repositories;
using System;
using System.Collections.Generic;

namespace MyProject.Mock
{
    public class MockContext : IContex
    {
        public List<Role> Roles { get; set; }
        public List<claim> Claims { get; set; }
        public List<Permission> Permissions { get; set; }

        public MockContext()
        {
            this.Roles = new List<Role>();
            this.Permissions = new List<Permission>();
            this.Claims = new List<claim>();

            this.Roles.Add(new Role { Id = 1, Name = "admin", Descreption = "administrator with full access" });
            this.Roles.Add(new Role { Id = 2, Name = "user", Descreption = "user with limited access" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ORDERS" });
            this.Permissions.Add(new Permission { Id = 2, Name = "VIEW_ALL_PRODUCTS" });

            this.Claims.Add(new claim { Id = 1, RoleId = 1, PermissionId = 1, epolicy = Epolicy.Allow });
            this.Claims.Add(new claim { Id = 2, RoleId = 2, PermissionId = 1, epolicy = Epolicy.Deny });
            this.Claims.Add(new claim { Id = 3, RoleId = 1, PermissionId = 2, epolicy = Epolicy.Allow });
            //this.Claims.Add(new Claim { Id = 4, RoleId = 2, PermissionId = 2, Policy = EPolicy.Allow });
        }
    }
}
