using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminNationality : AdminTrackable<Nationality, int>
    {
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("Nationality")]
        //public int NationalityId { get; set; }
        //public Nationality Nationality { get; set; }

        //public DateTime? CreateAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
    }
}
