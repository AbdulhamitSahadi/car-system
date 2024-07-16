using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminPerson : AdminTrackable<Person, int>
    {
        //[Key]
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }


        //[ForeignKey("Person")]
        //public int PersonId { get; set; }
        //public Person Person { get; set; }
    }
}
