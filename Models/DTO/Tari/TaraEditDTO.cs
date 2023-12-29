using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Models.DTO.Tari
{
    public class TaraEditDTO
    {
        [Key]
        public int IdTara { get; set; }

        public string? Denumire { get; set; }
    }
}