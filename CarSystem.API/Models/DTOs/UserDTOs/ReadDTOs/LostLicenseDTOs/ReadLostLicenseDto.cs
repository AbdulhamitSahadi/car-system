using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.LostLicenseDTOs
{
    public class ReadLostLicensePermissionDto
    {
        public int Id { get; set; }

        public License License { get; set; }

        public DateTime DateReported { get; set; }

        public string Reason { get; set; }

        public Application Application { get; set; }

        public string? Notes { get; set; }
    }
}
