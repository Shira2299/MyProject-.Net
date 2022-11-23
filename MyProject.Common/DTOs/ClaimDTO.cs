using MyProject.Repositories;
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

        public Role Role { get; set; }

        public Permission Permission { get; set; }

        public Epolicy epolicy { get; set; }
    }
}
