using CarSystem.API.Models.Domain;

namespace CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.DamageLicenseDTOs
{
    public class ReadDamageLicenseDto
    {
        public int Id { get; set; }

        //[Required]
        //[ForeignKey(nameof(License))]
        public License License { get; set; }

        //[Required]
        //[DataType(DataType.DateTime)]
        public DateTime DateReported { get; set; }

        //[StringLength(500)]
        public string? Notes { get; set; }

        //[Required]
        //[ForeignKey("Application")]
        public Application Application { get; set; }

        //[Required]
        //[StringLength(200)]
        public string Reason { get; set; }
    }
}
