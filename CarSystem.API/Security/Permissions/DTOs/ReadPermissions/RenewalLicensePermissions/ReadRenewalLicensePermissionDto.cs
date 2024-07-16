using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.RenewalLicensePermissions
{
    public class ReadRenewalLicensePermissionDto
    {
        public int Id { get; set; }
        public License License { get; set; }

        public Application Application { get; set; }

        public DateTime RenewalDate { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
    }
}
