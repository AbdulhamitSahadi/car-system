using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSystem.API.Models.Domain
{
    public class TakeTest : DomainTrackable<AdminTakeTest>
    {
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }


        public ICollection<Question> Questions { get; set; }
        public ICollection<int> Options { get; set; }


        public int TestCategoryId { get; set; }
        public TestCategory TestCategory { get; set; }
    }
}
