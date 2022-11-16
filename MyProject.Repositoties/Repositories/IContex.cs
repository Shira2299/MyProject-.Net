using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace MyProject.Repositoties.Repositories
{
    public interface IContex
    {
        DbSet<Role> Roles { get; set; }

        DbSet<Claim> Claims { get; set; }

        DbSet<Permission> Permissions { get; set; }
    }
}
