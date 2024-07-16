using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.TakeTestDTOs
{
    public class ReadTakeTestPermissionDto
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
