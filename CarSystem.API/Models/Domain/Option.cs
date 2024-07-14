using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Content { get; set; }

        [Required]
        public bool IsCorrect { get; set; } = false;

        [Required]
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
