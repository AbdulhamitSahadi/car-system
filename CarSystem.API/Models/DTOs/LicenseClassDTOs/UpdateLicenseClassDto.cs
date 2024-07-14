using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LicenseClassDTOs
{
    public class UpdateLicenseClassDto
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        [Required]
        public int MinimumAllowedAge { get; set; }

        [Required]
        public int ValidityLength { get; set; }

        [Required]
        public double Fees { get; set; }

        public string? Notes { get; set; }
    }
}
