using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.LostLicenseDTOs
{
    public class CreateLostLicenseDto
    {
        [StringLength(50)]
        [Required]
        public string Reason { get; set; }


        [StringLength(500)]
        public string? Notes { get; set; }
    }
}
