using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.OptionDTOs
{
    public class UpdateOptionDto
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
    }
}
