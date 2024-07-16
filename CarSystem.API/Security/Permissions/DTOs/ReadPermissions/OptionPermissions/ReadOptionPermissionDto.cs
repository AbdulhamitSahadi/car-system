using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.AdminDTO.SuperAdminDTOs.OptionSuperAdminDTOs
{
    public class ReadOptionPermissionDto
    {
        public int Id { get;set; }

        public string Content { get; set; }

        public Question Question { get; set; }
    }
}
