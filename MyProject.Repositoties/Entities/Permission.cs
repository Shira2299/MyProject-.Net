using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.Repositoties
{
   public class Permission
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Descreption:{Description}";
        }
    }
}
