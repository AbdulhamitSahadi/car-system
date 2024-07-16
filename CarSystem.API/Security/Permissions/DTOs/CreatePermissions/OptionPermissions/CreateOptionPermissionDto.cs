namespace CarSystem.API.Security.Permissions.DTOs.CreatePermissions.OptionPermissions
{
    public class CreateOptionPermissionDto
    {
        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}
