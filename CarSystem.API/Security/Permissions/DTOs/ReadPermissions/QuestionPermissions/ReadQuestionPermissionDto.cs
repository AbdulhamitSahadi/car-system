using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.QuestionPermissions
{
    public class ReadQuestionPermissionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TestCategoryId { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
