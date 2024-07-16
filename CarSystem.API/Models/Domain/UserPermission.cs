using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;

namespace CarSystem.API.Models.Domain
{
    public class UserPermission : DomainTrackable<AdminUserPermission>
    {

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
