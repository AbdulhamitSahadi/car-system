using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminDriver : AdminTrackable<Driver, int>
    {
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("Driver")]
        //public int DriverId { get; set; }
        //public Driver Driver { get; set; }
    }
}
