using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.NationalityDTOs
{
    public class CreateNationalityDto
    {
        [Required]
        public string Name { get; set; }
    }
}
