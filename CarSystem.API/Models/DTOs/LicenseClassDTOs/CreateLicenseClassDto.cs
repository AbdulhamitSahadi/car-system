using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LicenseClassDTOs
{
    public class CreateLicenseClassDto
    {
        [Required]
        public LicenseClassType Name { get; set; }

        public string? Description { get; set; }

        [Required]
        [Range(18, 80)]
        public int MinimumAllowedAge { get; set; }


        [Required]
        [Range(1, 10)]
        public int ValidityLength { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Fees { get; set; }


        public string? Notes { get; set; }
    }
}
