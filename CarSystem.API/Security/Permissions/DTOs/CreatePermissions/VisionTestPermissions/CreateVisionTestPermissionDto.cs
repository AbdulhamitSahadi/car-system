using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.CreatePermissions.VisionTestPermissions
{
    public class CreateVisionTestPermissionDto
    {
        [Required]
        public decimal Score { get; set; }

        public string? Notes { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public int TestId { get; set; }
    }
}
