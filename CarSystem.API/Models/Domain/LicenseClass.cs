using CarSystem.API.Enums;
using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarSystem.API.Models.Domain
{
    public class LicenseClass : DomainTrackable<AdminLicenseClass>
    {
        //[Key]
        //public int Id { get; set; }


        [Required]
        public LicenseClassType Name { get; set; }


        [StringLength(200)]
        public string? Description { get; set; }

        [Range(18, 80)]
        [Required]
        public int MinimumAllowedAge { get; set; }

        [Range(1, 10)]
        [Required]
        public int ValidityLength { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public double Fees { get; set; }

        [StringLength(200)]
        public string? Notes { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
    }
}
