using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.CreatePermissions.PermissionPermissions
{
    public class CreatePermissionDto
    {
        public PermissionName Name { get; set; }

        public PermissionType Type { get; set; }

        public Status Status { get; set; }
    }
}
