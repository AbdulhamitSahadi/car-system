using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.AdminPermissions
{
    public class UpdateAdminPermissionDto
    {
        public int Id { get; set; }

        public AdminLevel AdminLevel { get; set; } 

        public bool IsActive { get; set; }

        public Status Status { get; set; }
    }
}
