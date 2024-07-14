namespace CarSystem.API.Models.Domain.Base.IEntity
{
    public interface ITrackable
    {
        DateTime? UpdatedAt { get; set; }
        DateTime? CreatedAt { get; set; }
    }
}
