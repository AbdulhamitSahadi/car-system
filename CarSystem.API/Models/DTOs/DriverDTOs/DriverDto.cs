using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.DriverDTOs
{
    public class DriverDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }

        public ICollection<License> OwnedLicenses { get; set; }
    }
}
