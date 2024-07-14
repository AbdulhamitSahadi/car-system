using CarSystem.API.Enums;

namespace CarSystem.API.Models.DTOs.ApplicationDTOs
{
    public class UpdateApplicationDto
    {
        public int Id { get; set; }

        public ApplicationType ApplicationType { get; set; }
    }
}
