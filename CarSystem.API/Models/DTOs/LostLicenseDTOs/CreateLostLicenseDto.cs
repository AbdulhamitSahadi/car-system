using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LostLicenseDTOs
{
    public class CreateLostLicenseDto
    {
        [Required]
        public DateTime DateReported { get; set; }

        [Required]
        public string Reason { get; set; }

        public string? Notes { get; set; }

        public int LicenseId { get; set; }

        public int ApplicationId { get; set; }
    }
}
