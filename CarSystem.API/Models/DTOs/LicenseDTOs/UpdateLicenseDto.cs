using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LicenseDTOs
{
    public class UpdateLicenseDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
