using CarSystem.API.Enums;
using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.PersonDTOs
{
    public class ReadPersonPermissionDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public Nationality Nationality { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        //[NotMapped] 
        public int Age
        {
            get
            {
                DateTime now = DateTime.UtcNow;
                int age = now.Year - BirthDate.Year;

                if (BirthDate.Date > now.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
    }
}
