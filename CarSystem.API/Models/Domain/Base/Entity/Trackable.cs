using CarSystem.API.Models.Domain.Base.IEntity;

namespace CarSystem.API.Models.Domain.Base.Entity
{
    public class Trackable :  ITrackable
    {
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
