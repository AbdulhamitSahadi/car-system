using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.DamageLicenseDTOs
{
    public class UpdateDamageLicenseDto
    {
        public int Id { get; set; }

        [Required]
        public string Reason { get; set; }
    }
}
