using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.AdminDTOs
{
    public class CreateAdminDto
    {
        [Required(ErrorMessage = "Admin level is required field")]
        public AdminLevel AdminLevel { get; set; }


        [Required(ErrorMessage = "User is required field")]
        public int UserId { get; set; } //here only id, because I don't want to object of user


        [Required]
        public bool IsActive { get; set; }



    }
}
