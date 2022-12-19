using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject.Repositories
{
    public interface IContex
    {
        DbSet<Role> Roles { get; set; }

        DbSet<Permission> Permissions { get; set; }

        DbSet<Claim> Claims { get; set; }

        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
