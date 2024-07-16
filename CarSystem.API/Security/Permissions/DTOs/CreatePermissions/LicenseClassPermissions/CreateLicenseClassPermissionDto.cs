using CarSystem.API.Enums;

namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.LicenseClassSuperAdminDTOs
{
    public class CreateLicenseClassPermissionDto
    {
        public LicenseClassType Name { get; set; }


        public string? Description { get; set; }


        public int MinimumAllowedAge { get; set; }

        public int ValidityLength { get; set; }

        public double Fees { get; set; }

        public string? Notes { get; set; }
    }
}
