using CarSystem.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.TestCategoryPermissions
{
    public class UpdateTestCategoryPermissionDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        public int NumberOfQuestions { get; set; }

        public Status Status { get; set; }
    }
}
