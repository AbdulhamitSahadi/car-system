using CarSystem.API.Models.Domain;

namespace CarSystem.API.Security.Permissions.DTOs.ReadPermissions.TestPermissions
{
    public class ReadTestPermissionDto
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public double Fees { get; set; }

        public int TestCategoryId { get; set; }


        public bool IsCompleted { get; set; }

        public ICollection<WritingTest> WrittenTests { get; set; }
        public ICollection<VisionTest> VisionTests { get; set; }
    }
}
