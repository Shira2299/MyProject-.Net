using MyProject.Repositories;

namespace MyProject.WebApi.Models
{
    public class ClaimModel
    {
        public Role RoleId { get; set; }
        public Permission PermissionId { get; set; }
        public Epolicy epolicy { get; set; }
    }
}
