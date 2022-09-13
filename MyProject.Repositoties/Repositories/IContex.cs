using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositoties.Repositories
{
    public interface IContex
    {
        List<Role> Roles {get; set;}
        List<claim> Claims { get; set; }
        List<Permission> Permissions { get; set; }
    }
}
