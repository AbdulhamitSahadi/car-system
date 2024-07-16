using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.QuestionSuperAdminDTOs
{
    public class ReadQuestionPermissionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TestCategoryId { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
