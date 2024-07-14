using CarSystem.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace CarSystem.API.Models.DTOs.VisionTestDTOs
{
    public class VisionTestDto
    {
        public int Id { get; set; }
        public decimal Score { get; set; }

        public string? Notes { get; set; }


        public bool IsSuccess { get; set; }

   
        public Test Test { get; set; }
    }
}
