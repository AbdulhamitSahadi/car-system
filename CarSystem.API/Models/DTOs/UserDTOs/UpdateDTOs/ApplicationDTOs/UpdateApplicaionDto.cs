using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.ApplicationDTOs
{
    public class UpdateApplicationDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Application type is required field!")]
        public ApplicationType ApplicationType { get; set; }


        [Required(ErrorMessage = "License class type is required! field!")]
        public LicenseClassType LicenseClassType { get; set; }
    }
}
