namespace CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.TestPermissions
{
    public class UpdateTestPermissionDto
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public double Fees { get; set; }

        public int TestCategoryId { get; set; }


        public bool IsCompleted { get; set; }
    }
}
