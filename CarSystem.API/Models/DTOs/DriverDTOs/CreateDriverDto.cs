using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.DriverDTOs
{
    public class CreateDriverDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int AdminId { get; set; }
    }
}
