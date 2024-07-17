using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.PermissionPermissions
{
    public class UpdatePermissionPermissionDto
    {
        public int Id { get; set; }

        public PermissionName Name { get; set; }

        public PermissionType Type { get; set; }
    }
}
