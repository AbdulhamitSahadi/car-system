using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.User.CreateDTOs.TakeTestDTOs
{
    public class CreateTakeTestDto
    {
        public DateTime IssueDate { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<int> UserSelectedOptions { get; set; }
    }
}
