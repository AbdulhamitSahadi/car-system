using CarSystem.API.Enums;
using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;

namespace CarSystem.API.Models.Domain
{
    public class Permission : DomainTrackable<AdminPermission>
    {
        public int Id { get; set; }

        public PermissionName Name { get; set; }

        public PermissionType Type { get; set; }

        public ICollection<UserPermission> UsersPermissions { get; set; }
    }
}
