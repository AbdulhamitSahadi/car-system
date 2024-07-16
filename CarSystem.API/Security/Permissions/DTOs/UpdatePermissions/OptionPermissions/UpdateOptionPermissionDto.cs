namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.OptionSuperAdminDTOs
{
    public class UpdateOptionPermissionDto
    {
        public int Id { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}
