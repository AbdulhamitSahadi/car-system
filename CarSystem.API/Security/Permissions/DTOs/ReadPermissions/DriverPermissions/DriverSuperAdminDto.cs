using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.DriverSuperAdminDTOs
{
    public class DriverSuperAdminDto
    {
        public bool IsActive { get; set; }


        public User User { get; set; }

        public ICollection<License>? OwnedLicenses { get; set; }
    }
}
