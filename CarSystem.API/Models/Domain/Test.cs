using CarSystem.API.Enums;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class Test : DomainTrackable
    { 
        //[Key]
        //public int Id { get; set; }

        [Required]
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "0:C2", ApplyFormatInEditMode = true)]
        public double Fees { get; set; }

        //[Required]
        //public DateTime CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }

        //[Required]
        //[ForeignKey("EditedBy")]
        //public int AdminId { get; set; }
        //public Admin EditedBy { get; set; }

        [Required]
        [ForeignKey("TestCategoryId")]
        public int TestCategoryId { get; set; }
        public TestCategory TestCategory { get; set; }


        //[Required]
        //[ForeignKey("VisionTest")]
        //public int VisionTestId { get; set; }
        //public VisionTest VisionTest { get; set; }


        //[ForeignKey("WrittenTest")]
        //public int WrittenTestId { get; set; }
        //public WrittenTest? WrittenTest { get; set; }

        //[Required]
        //[ForeignKey("Application")]
        //public int ApplicationId { get; set; }
        //public Application Application { get; set; }


        //[Required]
        //[ForeignKey("VisionTest")]
        //public int VisionTestId { get; set; }
        //public VisionTest VisionTest { get; set; }


        //[ForeignKey("WrittenTest")]
        //public int WrittenTestId { get; set; }
        //public WrittenTest? WrittenTest { get; set; } //if don't pass the vision test, this field will remain nullable


        //[ForeignKey("PracticalTest")]
        //public int PracticalTestId { get; set; }
        //public PracticalTest? PracticalTest { get; set; }

        public bool IsCompleted { get; set; }

        public ICollection<WritingTest> WrittenTests { get; set; }
        public ICollection<VisionTest> VisionTests { get; set; }
    }
}
