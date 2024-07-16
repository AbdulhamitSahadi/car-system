using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.ApplicationDTOs
{
    public class ReadApplicationDto
    {
        public int Id { get; set; }


        public User User { get; set; }


        public Status Status { get; set; }


        public ApplicationType Type { get; set; }


        public LicenseClassType LicenseClassType { get; set; }

    }
}
