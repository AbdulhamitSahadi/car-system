using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class LostLicense : DomainTrackable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("License")]
        public int LicenseId { get; set; }
        public License License { get; set; }

        [Required]
        public DateTime DateReported { get; set; }

        [Required]
        [StringLength(100)]
        public string Reason { get; set; }

        [Required]
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }


        [StringLength(500)]
        public string? Notes { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")] 
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
    }
}
