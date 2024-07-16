using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.TestDTOs
{
    public class ReadTestDto
    {
        public int Id { get; set; }
        public Application Application { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        [DisplayFormat(DataFormatString = "0:C2", ApplyFormatInEditMode = true)]
        public double Fees { get; set; }

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
