using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApp.Models.Entities
{
    [Table("Antrenori")]
    public class Antrenor
    {
        [Key]
        public int IdAntrenor { get; set; }

        public required DateOnly DataNasterii { get; set; }

        public required string Nume { get; set; }

        public required string Prenume { get; set; }

        public string? PozaProfil { get; set; }

        public int IdTara { get; set; }
    }
}