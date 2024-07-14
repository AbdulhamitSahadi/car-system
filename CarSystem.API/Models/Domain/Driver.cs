using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Driver : DomainTrackable
    {
        //[Key]
        //public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        //[Required]  
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }


        public ICollection<License> OwnedLicenses { get; set; }
    }
}
