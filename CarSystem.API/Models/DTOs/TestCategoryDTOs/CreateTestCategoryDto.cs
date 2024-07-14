using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.TestCategoryDTOs
{
    public class CreateTestCategoryDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        public int NumberOfQuestions { get; set; }
    }
}
