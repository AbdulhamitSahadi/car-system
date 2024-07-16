using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminUser : AdminTrackable<User, int>
    {
        //[Key]
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("User")]
        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
