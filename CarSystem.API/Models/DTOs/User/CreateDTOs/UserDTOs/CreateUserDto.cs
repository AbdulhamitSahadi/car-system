using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.User.CreateDTOs.UserDTOs
{
    public class CreateUserDto
    {
        [Required]
        public int PersonId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
