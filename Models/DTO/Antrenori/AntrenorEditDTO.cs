using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Models.DTO.Antrenori
{
    public class AntrenorEditDTO
    {
        [Key]
        public int IdAntrenor { get; set; }

        public string? Nume { get; set; }

        public string? Prenume { get; set; }

        public int IdTara { get; set; }

        public DateOnly DataNasterii { get; set; }
    }
}