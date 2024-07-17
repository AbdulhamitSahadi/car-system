using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.DriverPermissions
{
    public class UpdateDriverPermissionDto
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public bool IsActive { get; set; }
    }
}
