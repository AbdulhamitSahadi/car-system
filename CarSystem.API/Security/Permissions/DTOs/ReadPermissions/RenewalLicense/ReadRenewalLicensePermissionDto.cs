using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.RenewalLicenseDTOs
{
    public class ReadRenewalLicensePermissionDto
    {
        public int Id { get; set; }
        public License License { get; set; }

        public Application Application { get; set; }

        public DateTime RenewalDate { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
    }
}
