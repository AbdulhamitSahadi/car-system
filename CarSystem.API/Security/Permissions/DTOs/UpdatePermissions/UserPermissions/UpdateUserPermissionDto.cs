using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.UserPermissions
{
    public class UpdateUserPermissionDto
    {

        public Status Status { get; set; }

        public bool IsActive { get; set; }
    }
}
