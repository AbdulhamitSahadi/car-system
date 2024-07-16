using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.VisionTestPermissions
{
    public class UpdateVisionTestPermissionDto
    {
        public int Id { get; set; }
        [Required]
        public decimal Score { get; set; }

        public string? Notes { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public int TestId { get; set; }
    }
}
