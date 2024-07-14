using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set;  }
        //public Admin EditedBy { get; set;  }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Person>? People { get; set; }
    }
}
