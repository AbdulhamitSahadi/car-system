using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.WritingTestDTOs
{
    public class WritingTestDto
    {
        public int Id { get; set; }
        public decimal Score { get; set; }

        public string? Notes { get; set; }


        public bool IsSuccess { get; set; }


        public Test Test { get; set; }
    }
}
