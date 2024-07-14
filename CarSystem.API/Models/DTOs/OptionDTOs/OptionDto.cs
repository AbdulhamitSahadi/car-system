using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.OptionDTOs
{
    public class OptionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
    }
}
