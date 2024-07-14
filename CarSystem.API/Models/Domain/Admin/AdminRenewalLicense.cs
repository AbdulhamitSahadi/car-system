using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminRenewalLicense
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("RenewalLicense")]
        public int RenewalLicenseId { get; set; }
        public RenewalLicense RenewalLicense { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set;
    }
}
