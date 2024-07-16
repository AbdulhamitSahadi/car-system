using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.UserDTOs
{
    public class ReadUserPermissionDto
    {
        public int Id { get; set; }


        public string UserName { get; set; }


        public bool IsActive { get; set; }


        public int PersonId { get; set; }


        public ICollection<Application> Applications { get; set; }
    }
}
