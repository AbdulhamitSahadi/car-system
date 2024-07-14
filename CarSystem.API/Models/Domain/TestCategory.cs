using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.Domain
{
    public class TestCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        [Range(10, 100)]

        public int NumberOfQuestions { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }
    }
}
