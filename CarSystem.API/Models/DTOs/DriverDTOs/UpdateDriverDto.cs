using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.DriverDTOs
{
    public class UpdateDriverDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
