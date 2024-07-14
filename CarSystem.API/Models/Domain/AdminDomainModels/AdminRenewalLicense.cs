using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminRenewalLicense : AdminTrackable<RenewalLicense, int>
    {
        //[Key]
        //public int Id { get; set; }


        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("RenewalLicense")]
        //public int RenewalLicenseId { get; set; }
        //public RenewalLicense RenewalLicense { get; set; }
    }
}
