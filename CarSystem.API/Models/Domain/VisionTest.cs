using CarSystem.API.Models.Domain.Base.Entity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class VisionTest : DomainTrackable
    {
        //[Key]
        //public int Id { get; set; }

        //[Required]
        //[ForeignKey(nameof(Application))]
        //public int ApplicationId { get; set; }
        //public Application Application { get; set; }

        [DisplayFormat(DataFormatString = "0:C2", ApplyFormatInEditMode = true)]
        public decimal Score { get; set; }

        [StringLength(500)]
        public string? Notes { get; set; }

        [Required]
        public bool IsSuccess { get; set; }


        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        [Required]
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
