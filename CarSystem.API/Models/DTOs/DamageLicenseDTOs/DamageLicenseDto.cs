using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.DamageLicenseDTOs
{
    public class DamageLicenseDto
    {
        public int Id { get; set; }

        public License License { get; set; }

        public DateTime DateReported { get; set; }

        public string? Notes { get; set; }

        public Application Application { get; set; }

        public string Reason { get; set; }


    }
}
