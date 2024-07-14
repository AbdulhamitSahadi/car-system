using Microsoft.Identity.Client;

namespace CarSystem.API.Models.DTOs.LicenseClassDTOs
{
    public class LicenseClassDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Fees { get; set; }
        public int MinimumAllowedAge { get; set; }

        public int ValidityLength { get; set; }
        public string? Notes { get; set; }

        public string? Description { get; set; }
    }
}
