using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class RenewalLicense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(License))]
        public int LicenseId { get; set; }
        public License License { get; set; }

        [Required]
        [ForeignKey(nameof(Application))]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime RenewalDate { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ExpirationDate { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }
    }
}
