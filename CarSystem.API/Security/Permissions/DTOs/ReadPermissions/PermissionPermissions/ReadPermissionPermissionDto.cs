using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.PermissionPermissions
{
    public class ReadPermissionPermissionDto
    {
        public int Id { get; set; }

        public PermissionName Name { get; set; }

        public PermissionType Type { get; set; }

        public ICollection<UserPermission> UsersPermissions { get; set; }
    }
}
