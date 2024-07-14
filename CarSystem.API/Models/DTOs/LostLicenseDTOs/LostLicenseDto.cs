using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.LostLicenseDTOs
{
    public class LostLicenseDto
    {
        public int Id { get; set; }

        public License License { get; set; }

        public DateTime DateReported { get; set; }

        public string Reason { get; set; }

        public Application Application { get; set; }

        public string? Notes { get; set; }
    }
}
