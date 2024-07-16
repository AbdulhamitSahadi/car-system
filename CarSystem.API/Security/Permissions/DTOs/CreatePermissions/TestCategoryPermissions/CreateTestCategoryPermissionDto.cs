using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Security.Permissions.DTOs.CreatePermissions.TestCategoryPermissions
{
    public class CreateTestCategoryPermissionDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        public int NumberOfQuestions { get; set; }
    }
}
