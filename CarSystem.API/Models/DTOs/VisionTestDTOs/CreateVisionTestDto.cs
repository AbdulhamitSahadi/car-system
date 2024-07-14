using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.VisionTestDTOs
{
    public class CreateVisionTestDto
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
