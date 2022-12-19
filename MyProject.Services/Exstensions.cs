using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories;
using MyProject.Repositories.Interface;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
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
        public static IServiceCollection AddServices(this IServiceCollection services)
        {           
            services.AddRepositories();
            services.AddScoped<IRoleService, RoleServices>();
            services.AddScoped<IClaimServices, ClaimServices>();
            services.AddScoped<IPermmisionServices, PermissionServices>();
            services.AddScoped<IUserServices,UserServices>();  
            services.AddAutoMapper(typeof(Mapper));
            return services;
        }
    }
}
