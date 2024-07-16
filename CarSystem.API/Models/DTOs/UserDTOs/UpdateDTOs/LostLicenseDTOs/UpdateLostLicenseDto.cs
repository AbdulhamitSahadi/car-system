using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.LostLicenseDTOs
{
    public class UpdateLostLicenseDto
    {
        [Required]
        [StringLength(50)]
        public string Reason { get; set; }


        [StringLength(500)]
        public string? Notes { get; set; }
    }
}
