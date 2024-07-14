using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.NationalityDTOs
{
    public class NationalityDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
