namespace CarSystem.API.Models.Domain.Base.IEntity
{
    public interface IDomainTrackable
    {
        int Id { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? CreatedAt { get; set; }
    }
}
