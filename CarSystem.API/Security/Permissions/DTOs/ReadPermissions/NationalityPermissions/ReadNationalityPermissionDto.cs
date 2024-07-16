using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.NationalityPermissions
{
    public class ReadNationalityPermissionDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
