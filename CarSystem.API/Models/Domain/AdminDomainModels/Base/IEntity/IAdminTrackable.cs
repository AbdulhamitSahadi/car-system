namespace CarSystem.API.Models.Domain.AdminDomainModels.Base.IEntity
{
    public interface IAdminTrackable<TEntity, TKey>
    {
        int Id { get; set; }
        int AdminId { get; set; }
        Admin Admin { get; set; }

        TKey EntityId { get; set; }
        TEntity Entity { get; set; }

        DateTime? CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}
