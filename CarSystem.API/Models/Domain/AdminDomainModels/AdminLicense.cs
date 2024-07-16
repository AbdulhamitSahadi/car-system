using CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity;

namespace CarSystem.API.Models.Domain.AdminDomainModels
{
    public class AdminLicense : AdminTrackable<License, int>
    {
        //[Key]
        //public int Id { get; set; }

        //[ForeignKey("Admin")]
        //public int AdminId { get; set; }
        //public Admin Admin { get; set; }

        //[ForeignKey("License")]
        //public int LicenseId { get; set; }
        //public License License { get; set; }
    }
}
