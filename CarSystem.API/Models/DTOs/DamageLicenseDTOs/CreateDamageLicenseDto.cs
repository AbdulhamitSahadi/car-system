using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.DamageLicenseDTOs
{
    //not for user, it's an admin role
    public class CreateDamageLicenseDto
    {
        [Required]
        public int LicenseId { get; set; }

        [Required]
        [StringLength(200)]
        public string Reason { get; set; }

        [Required]
        public int DateReported { get; set; }

        public string? Notes { get; set; }

        [Required]
        public Application ApplicationId { get; set; }
    }
}
