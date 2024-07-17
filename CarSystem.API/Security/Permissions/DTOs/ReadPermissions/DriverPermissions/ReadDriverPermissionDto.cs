using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.DriverPermissions
{
    public class ReadDriverPermissionDto
    {
        public bool IsActive { get; set; }


        public User User { get; set; }

        public ICollection<License>? OwnedLicenses { get; set; }
    }
}
