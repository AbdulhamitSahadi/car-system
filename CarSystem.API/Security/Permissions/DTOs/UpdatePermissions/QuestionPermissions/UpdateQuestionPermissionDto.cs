using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.QuestionPermissions
{
    public class UpdateQuestionPermissionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TestCategoryId { get; set; }

        public Status Status { get; set; }
    }
}
