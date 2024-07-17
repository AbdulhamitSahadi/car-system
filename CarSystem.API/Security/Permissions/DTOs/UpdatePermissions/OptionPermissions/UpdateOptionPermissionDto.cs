using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.OptionPermissions
{
    public class UpdateOptionPermissionDto
    {
        public int Id { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }


        public Status Status { get; set; }
    }
}
