using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.PersonDTOs
{
    public class UpdatePersonDto
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public int NationalityId { get; set; }
    }
}
