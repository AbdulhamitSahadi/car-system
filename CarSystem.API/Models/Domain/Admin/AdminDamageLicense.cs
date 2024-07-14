using CarSystem.API.Models.Domain.Base.Entity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminDamageLicense : Trackable
    {
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("DamageLicense")]
        public int DamageLicenseId { get; set; }
        public DamageLicense DamageLicense { get; set; }
    }
}
