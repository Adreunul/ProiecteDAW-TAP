using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace AspNetCoreApp.Models.Entities
{
    [Table("Jucatori")]
    public class Jucator
    {
        [Key]
        public int IdJucator { get; set; }

        public int IdTara { get; set; }

        public int IdEchipa { get; set; }

        public int IdPozitie { get; set; }

        public required DateOnly DataNasterii { get; set; }

        public required string Nume { get; set; }

        public required string Prenume { get; set; }

        public string? PozaProfil { get; set; }

        public decimal Salariu { get; set; }

    }
}