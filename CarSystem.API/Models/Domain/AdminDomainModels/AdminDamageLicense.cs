using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;
using CarSystem.API.Models.Domain.Base.Entity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminDamageLicense : AdminTrackable<DamageLicense, int>
    {
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("DamageLicense")]
        //public int DamageLicenseId { get; set; }
        //public DamageLicense DamageLicense { get; set; }
    }
}
