using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminApplication : Trackable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
