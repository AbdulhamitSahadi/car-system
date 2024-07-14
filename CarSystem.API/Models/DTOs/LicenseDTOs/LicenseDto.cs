using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.LicenseDTOs
{
    public class LicenseDto
    {
        public int Id { get; set; }

        public int LicenseNumber { get; set; }

        public Driver Driver { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public ApplicationType ApplicationType { get; set; }

        public LicenseClassType LicenseClassType { get; set; }

        public Application Application { get; set; }
    }
}
