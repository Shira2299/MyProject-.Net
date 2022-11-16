using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.Repositoties
{
    public enum Epolicy { Allow, Deny, Mandatory }
    public class Claim
    {
        public int Id { get; set; }

        [Required]
        public Role RoleId { get; set; }

        [Required]
        public Permission PermissionId { get; set; }

        public Epolicy epolicy { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} RoleId:{RoleId} PermissionId:{PermissionId}";
        }
    }
}
