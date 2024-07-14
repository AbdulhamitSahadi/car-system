using CarSystem.API.Models.Domain.Base.IEntity;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.Domain.Base.Entity
{
    public class DomainTrackable<TEntity> :  IDomainTrackable<TEntity>
    {
        [Key]
        public int Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }

        public ICollection<TEntity>? Admins_Entities { get; set; }
    }
}
