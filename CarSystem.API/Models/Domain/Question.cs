using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        [Required]
        public string Content { get; set; }



        [Required]
        [ForeignKey("TestCategory")]
        public int TestCategoryId { get; set; }
        public TestCategory TestCategory { get; set; }
        

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }



        public ICollection<Option> Options { get; set; }



    }
}
