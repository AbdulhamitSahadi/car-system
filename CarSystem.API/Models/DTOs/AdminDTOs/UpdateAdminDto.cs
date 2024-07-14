using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.AdminDTOs
{
    public class UpdateAdminDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Admin level is required field")]
        public AdminLevel AdminLevel { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
