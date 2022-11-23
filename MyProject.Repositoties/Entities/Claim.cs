using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.Repositories
{
    public enum Epolicy { Allow, Deny, Mandatory }
    public class Claim
    {
        public int Id { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required]
        public Permission Permission { get; set; }

        public Epolicy Policy { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} RoleId:{Role} PermissionId:{Permission}";
        }
    }
}
