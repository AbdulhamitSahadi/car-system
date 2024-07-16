using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.User.ReadDTOs.UserDTOs
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
