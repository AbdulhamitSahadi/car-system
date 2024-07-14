using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.QuestionDTOs
{
    public class UpdateQuestionDto
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }


        [Required]
        public int TestCategoryId { get; set; }
    }
}
