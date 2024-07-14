using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]    
        public int UserId { get; set; }
        public User User { get; set; }

        //[ForeignKey(nameof(LicenseId))] 
        //public int LicenseId { get; set; }
        //public License License { get; set; }

        [Required]
        public ApplicationStatus Status { get; set; }

        [Required]
        public ApplicationType Type { get; set; }

        [Required]
        public LicenseClassType LicenseClassType { get; set; }

        [Required]
        [ForeignKey("EditedBy")]
        public int AdminId { get; set; }
        public Admin EditedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<DamageLicense>? DamageLicenses { get; set; }
        public ICollection<License>? Licenses { get; set; }
        public ICollection<LostLicense>? LostLicenses { get; set; }
        public ICollection<RenewalLicense>? RenewalLicenses { get; set; }
        public ICollection<WritingTest>? WritingTests { get; set; }
        public ICollection<Test>? Tests { get; set; }
    }
}
