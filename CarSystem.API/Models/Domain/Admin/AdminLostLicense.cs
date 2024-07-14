using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminLostLicense : Trackable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }


        [ForeignKey("LostLicense")]
        public int LostLicenseId { get; set; }
        public LostLicense LostLicense { get; set; }
    }
}
