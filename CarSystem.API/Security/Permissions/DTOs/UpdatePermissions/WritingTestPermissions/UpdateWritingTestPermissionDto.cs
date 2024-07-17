using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.WritingTestPermission
{
    public class UpdateWritingTestPermissionDto
    {
        public int Id { get; set; }
        [Required]
        public decimal Score { get; set; }

        public string? Notes { get; set; }

        [Required]
        public bool IsSuccess { get; set; }

        [Required]
        public int TestId { get; set; }

        public Status Status { get; set; }
    }
}
