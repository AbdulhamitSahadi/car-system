namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.LicenseClassSuperAdminDTOs
{
    public class UpdateLicenseClassPermissionDto
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int MinimumAllowedAge { get; set; }

        public int ValidityLength { get; set; }

        public double Fees { get; set; }


        public string? Notes { get; set; }
    }
}
