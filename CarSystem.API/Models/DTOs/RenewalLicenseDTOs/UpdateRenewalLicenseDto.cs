using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.RenewalLicenseDTOs
{
    public class UpdateRenewalLicenseDto
    {
        public int Id { get; set; }

        //[Required]
        //public int LicenseId { get; set; }

        //[Required]
        //public int ApplicationId { get; set; }

        public DateTime RenewalDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string? Notes { get; set; }
    }
}
