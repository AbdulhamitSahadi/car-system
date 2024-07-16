using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.LicensePermissions
{
    public class ReadLicensePermissionDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public int LicenseNumber { get; set; }


        [Required]
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }


        [Required]
        public bool IsActive { get; set; }


        [Required]
        public LicenseClassType LicenseClassType { get; set; }


        [ForeignKey(nameof(Application))]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }





        [Required]
        public ApplicationType ReleaseType { get; set; }


        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        //[Required]
        //public DateTime CreateAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }


        public ICollection<DamageLicense>? DamageLicenses { get; set; }
        public ICollection<LostLicense>? LostLicenses { get; set; }
        public ICollection<RenewalLicense>? RenewalLicenses { get; set; }
    }
}
