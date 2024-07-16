using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.TakeTestPermissions
{
    public class ReadTakeTestPermissionDto
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
