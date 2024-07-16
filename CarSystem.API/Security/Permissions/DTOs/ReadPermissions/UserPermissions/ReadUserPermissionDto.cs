using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.UserPermissions
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
