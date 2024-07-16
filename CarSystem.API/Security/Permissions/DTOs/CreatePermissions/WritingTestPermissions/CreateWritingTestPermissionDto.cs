using System.ComponentModel.DataAnnotations;

namespace CarSystem.Security.Permissions.Models.CreatePermissions.WritingTestPermissions
{
    public class CreateWritingTestPermissionDto
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
