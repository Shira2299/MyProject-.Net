using MyProject.Repositoties;

namespace MyProject.WebApi.Models
{
    public class ClaimModel
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public Epolicy epolicy { get; set; }
       // public string Name { get; set; } check if we need
    }
}
