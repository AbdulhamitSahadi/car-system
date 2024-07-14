using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.LostLicenseDTOs
{
    public class UpdateLostLicenseDto
    {
        public int Id { get; set; }

        [Required]
        public string Reason { get; set; }

        public string? Notes { get; set; }
    }
}
