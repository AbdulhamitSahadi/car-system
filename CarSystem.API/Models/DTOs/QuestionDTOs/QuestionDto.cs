using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.QuestionDTOs
{
    public class QuestionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public TestCategory Category { get; set; }


        public ICollection<Option> Options { get; set; }
    }
}
