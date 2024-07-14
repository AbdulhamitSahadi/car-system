using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CarSystem.API.Models.Domain.Admin
{
    public class AdminDriver
    {
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
