using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositoties.Interface;
using MyProject.Repositoties.Interfaces;
using MyProject.Repositoties.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties
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
