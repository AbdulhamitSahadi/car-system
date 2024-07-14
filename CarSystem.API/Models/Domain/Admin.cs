using CarSystem.API.Enums;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Admin : DomainTrackable
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


        public ICollection<Admin>? Admins { get; set; }
        public ICollection<Application>? Applications { get; set; }
        public ICollection<DamageLicense>? DamageLicenses { get; set; }
        public ICollection<Driver>? Drivers { get; set; }
        public ICollection<License>? Licenses { get; set; }
        public ICollection<LicenseClass>? LicenseClasses { get; set; }
        public ICollection<LostLicense>? LostLicenses { get; set; }
        public ICollection<Nationality>? Nationalities { get; set; }
        public ICollection<Option>? Options { get; set; }
        //public ICollection<Person>? People { get; set; }
        public ICollection<Question>? Questions { get; set; }
        public ICollection<RenewalLicense>? RenewalLicenses { get; set; }
        public ICollection<Test>? Tests { get; set; }
        public ICollection<WritingTest>? WrittenTests { get; set; }
        public ICollection<User>? Users { get; set; }
        

    }
}
