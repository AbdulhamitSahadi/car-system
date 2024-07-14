using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.WritingTestDTOs
{
    public class UpdateWritingTestDto
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
