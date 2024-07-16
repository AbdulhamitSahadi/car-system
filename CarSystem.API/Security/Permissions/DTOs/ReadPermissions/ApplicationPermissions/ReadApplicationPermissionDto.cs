using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.ApplicationPermissions
{
    public class ReadApplicationPermissionDto
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public Status Status { get; set; }
        public ApplicationType Type { get; set; }

        public LicenseClassType LicenseClassType { get; set; }

        public ICollection<DamageLicense>? DamageLicenses { get; set; }
        public ICollection<License>? Licenses { get; set; }
        public ICollection<LostLicense>? LostLicenses { get; set; }
        public ICollection<RenewalLicense>? RenewalLicenses { get; set; }
        public ICollection<WritingTest>? WritingTests { get; set; }
        public ICollection<Test>? Tests { get; set; }
    }
}
