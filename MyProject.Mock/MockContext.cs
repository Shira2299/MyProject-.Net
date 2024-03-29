﻿using MyProject.Repositories;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;

namespace MyProject.Mock
{
    public class MockContext 
    {
        public List<Role> Roles { get; set; }
        public List<Claim> Claims { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<User> Users { get; set; }

        public MockContext()
        {
            this.Roles = new List<Role>();
            this.Permissions = new List<Permission>();
            this.Claims = new List<Claim>();
            this.Users = new List<User>();

            this.Roles.Add(new Role { Id = 1, Name = "admin", Description = "administrator with full access" });
            this.Roles.Add(new Role { Id = 2, Name = "user", Description = "user with limited access" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ORDERS" });
            this.Permissions.Add(new Permission { Id = 2, Name = "VIEW_ALL_PRODUCTS" });

            this.Claims.Add(new Claim { Id = 1/*, RoleId = 1, PermissionId = 1*/, Policy = Epolicy.Allow });
            this.Claims.Add(new Claim { Id = 2/*, RoleId = 2, PermissionId = 1*/, Policy = Epolicy.Deny });
            this.Claims.Add(new Claim { Id = 3/*, RoleId = 1, PermissionId = 2*/, Policy = Epolicy.Allow });
            //this.Claims.Add(new Claim { Id = 4, RoleId = 2, PermissionId = 2, Policy = EPolicy.Allow });
        }
    }
}
