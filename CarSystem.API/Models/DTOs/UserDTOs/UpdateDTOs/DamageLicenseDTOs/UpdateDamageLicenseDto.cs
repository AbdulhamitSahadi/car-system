using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.DamageLicenseDTOs
{
    public class UpdateDamageLicenseDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Reason is required field to update!")]
        public string Reason { get; set; }

        public string? Notes { get; set; }
    }
}
