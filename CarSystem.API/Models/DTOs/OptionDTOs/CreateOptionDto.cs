using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.OptionDTOs
{
    public class CreateOptionDto
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        [Required]
        public int QuestionId { get; set; }
    }
}
