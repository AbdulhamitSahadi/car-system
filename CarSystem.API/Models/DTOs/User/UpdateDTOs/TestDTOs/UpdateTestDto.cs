using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.User.UpdateDTOs.TestDTOs
{
    public class UpdateTestDto
    {
        public int Id { get; set; }

        [Required]
        public int ApplicationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        public int TestCategoryId { get; set; }

        [Required]
        public bool IsCompleted { get; set; }
    }
}
