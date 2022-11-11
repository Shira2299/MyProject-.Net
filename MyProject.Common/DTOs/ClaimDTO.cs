using MyProject.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ClaimDTO
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        public Epolicy epolicy { get; set; }
    }
}
