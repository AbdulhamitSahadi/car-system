namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.LicenseClassPermissions
{
    public class ReadLicenseClassPermissionDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Fees { get; set; }
        public int MinimumAllowedAge { get; set; }

        public int ValidityLength { get; set; }
        public string? Notes { get; set; }

        public string? Description { get; set; }
    }
}
