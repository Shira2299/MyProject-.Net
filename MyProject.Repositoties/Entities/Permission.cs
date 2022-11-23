using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Repositories
{
   public class Permission
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        //[Column(TypeName = "varchar(200)")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Descreption:{Description}";
        }

    }
}
