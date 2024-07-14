using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.ApplicationDTOs
{
    public class ApplicationDto
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ApplicationStatus Status { get; set; }
        public ApplicationType Type { get; set; }

        public LicenseClassType LicenseClassType { get; set; }

    }
}
