using CarSystem.API.Enums;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.NationalityPermissions
{
    public class UpdateNationalityPermissionDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }
    }
}
