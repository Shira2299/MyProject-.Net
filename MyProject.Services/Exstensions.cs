using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositoties;
using MyProject.Repositoties.Interface;
using MyProject.Repositoties.Interfaces;
using MyProject.Repositoties.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public static class Exstensions
    {
        public static IServiceCollection addServices(this IServiceCollection services)
        {           
            services.AddRepositories();
            services.AddScoped<IRoleService, RoleServices>();
            services.AddScoped<IClaimServices, ClaimServices>();
            services.AddScoped<IPermmisionServices, PermissionServices>();
            services.AddAutoMapper(typeof(Mapper));
            return services;
        }
    }
}
