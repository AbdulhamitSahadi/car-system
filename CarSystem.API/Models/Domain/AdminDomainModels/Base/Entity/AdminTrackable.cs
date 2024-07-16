using CarSystem.API.Models.Domain.AdminDomainModels.Base.IEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain.AdminDomainModels.Base.Entity
{
    public class AdminTrackable<TEntity, TKey> : IAdminTrackable<TEntity, TKey>
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey(nameof(Entity))]
        public TKey EntityId { get; set; }
        public TEntity Entity { get; set; }


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
