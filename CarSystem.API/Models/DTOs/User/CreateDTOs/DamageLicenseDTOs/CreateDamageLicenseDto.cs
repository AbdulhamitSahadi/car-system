using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.User.CreateDTOs.DamageLicenseDTOs
{
    public class CreateDamageLicenseDto
    {
        [StringLength(50)]
        [Required(ErrorMessage = "Reason is required field!")]
        public string Reason { get; set; }


        [StringLength(500)]
        public string? Notes { get; set; }
    }
}
