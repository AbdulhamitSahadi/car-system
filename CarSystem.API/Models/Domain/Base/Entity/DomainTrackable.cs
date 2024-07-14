using CarSystem.API.Models.Domain.Base.IEntity;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.Domain.Base.Entity
{
    public class DomainTrackable :  IDomainTrackable
    {
        [Key]
        public int Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
