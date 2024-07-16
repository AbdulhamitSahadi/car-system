using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;
using CarSystem.API.Models.Domain.Base.IEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class TakeTest : DomainTrackable<AdminTakeTest>
    {
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }


        public ICollection<Question> Questions { get; set; }
        public ICollection<int> Options { get; set; }


        [ForeignKey("VisionTest")]
        public int? VisionTestId { get; set; }
        public VisionTest? VisionTest { get; set; }


        [ForeignKey("WritingTest")]
        public int? WritingTestId { get; set; }
        public WritingTest? WritingTest { get; set; }
    }
}
