namespace CarSystem.API.Models.Domain.Base.IEntity
{
    public interface IDomainTrackable<TEntity>
    {
        int Id { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? CreatedAt { get; set; }

        ICollection<TEntity>? Admins_Entities { get; set; }
    }
}
