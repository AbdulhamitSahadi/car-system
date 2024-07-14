using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LicenseDTOs
{
    public class CreateLicenseDto
    {
        [Required]
        public int DriverId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public LicenseClassType LicenseType { get; set; }

        public ReleaseType ReleaseType { get; set; }

        public int ApplicationId { get; set; }
    }
}
