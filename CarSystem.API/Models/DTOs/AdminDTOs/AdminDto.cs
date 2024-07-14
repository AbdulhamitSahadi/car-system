using CarSystem.API.Enums;
using CarSystem.API.Extensions;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.AdminDTOs
{
    public class AdminDto
    {
        public int Id { get; set; }

        public AdminLevel AdminLevel { get; set; }

        public User User { get; set; }

        public bool IsActive { get; set; }

    }
}
