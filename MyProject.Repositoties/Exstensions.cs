using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories.Interface;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories
{
    public static class Exstensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermmisionRepository>();
            services.AddScoped<IClaimRepository, ClaimRepository>();
            return services;
        }
    }
}
