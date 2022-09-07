using System;

namespace MyProject.Repositoties
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Descreption:{Descreption}";
        }
    }
}
