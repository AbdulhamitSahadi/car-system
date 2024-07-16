using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.CreatePermissions.DriverPermissions
{
    public class CreateDriverPermissionDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int AdminId { get; set; }
    }
}
