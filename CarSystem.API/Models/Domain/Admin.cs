using CarSystem.API.Enums;
using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Admin : DomainTrackable<AdminPermission>
    {
        //[Key]
        //public int Id { get; set; }

        [Required]
        public AdminLevel AdminLevel { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public bool IsActive { get; set; }

        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }


        //[ForeignKey("EditedBy")]
        //public int? AdminId { get; set; }
        //public Admin? EditedBy { get; set; }

        public ICollection<AdminApplication>? AdminsApplications { get; set; }
        public ICollection<AdminDamageLicense>? AdminsDamageLicenses { get; set; }
        public ICollection<AdminDriver>? AdminsDrivers { get; set; }
        public ICollection<AdminLicense>? AdminsLicenses { get; set; }
        public ICollection<AdminLicenseClass>? AdminsLicenseClasses { get; set; }
        public ICollection<AdminLostLicense>? AdminsLostLicenses { get; set; }
        public ICollection<AdminNationality>? AdminsNationalities { get; set; }
        public ICollection<AdminOption>? AdminsOptions { get; set; }
        //public ICollection<Person>? People { get; set; }
        public ICollection<AdminPerson>? AdminsPeople { get; set; }
        public ICollection<AdminQuestion>? AdminsQuestions { get; set; }
        public ICollection<AdminRenewalLicense>? AdminsRenewalLicenses { get; set; }
        public ICollection<AdminTest>? AdminsTests { get; set; }
        public ICollection<AdminWritingTest>? AdminsWritingTests { get; set; }
        public ICollection<AdminVisionTest>? AdminsVisionTests { get; set; }

        //public ICollection<AdminPermission>? AdminsPermissions { get; set; }

        public ICollection<AdminUserPermission>? AdminsUserPermissions { get; set; }
        

    }
}
