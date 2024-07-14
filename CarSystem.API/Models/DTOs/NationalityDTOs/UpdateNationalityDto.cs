using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.NationalityDTOs
{
    public class UpdateNationalityDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
