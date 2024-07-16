using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.OptionPermissions
{
    public class ReadOptionPermissionDto
    {
        public int Id { get;set; }

        public string Content { get; set; }

        public Question Question { get; set; }
    }
}
