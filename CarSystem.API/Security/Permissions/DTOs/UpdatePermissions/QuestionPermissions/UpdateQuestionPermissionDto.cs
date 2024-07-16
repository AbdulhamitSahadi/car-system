namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.QuestionSuperAdminDTOs
{
    public class UpdateQuestionPermissionDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TestCategoryId { get; set; }
    }
}
