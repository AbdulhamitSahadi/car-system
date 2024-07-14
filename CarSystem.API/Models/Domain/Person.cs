using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [EmailAddress]
        [StringLength(100)]
        [Required]
        public string Email { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Phone]
        [StringLength(50)]
        public string? PhoneNumber { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [ForeignKey("Nationality")]   
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

        //[Required]
        //[ForeignKey("CreatedBy")]
        //public int AdminId { get; set; }
        //public Admin CreatedBy { get; set;  }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [NotMapped] 
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
