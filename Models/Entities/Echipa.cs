using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApp.Models.Entities
{
    [Table("Echipe")]
    public class Echipa
    {
        [Key]
        public int IdEchipa { get; set; }

        public int IdLocatie { get; set; }

        public int IdStadion { get; set; }

        public int IdAntrenor { get; set; }

        public int IdCampionat { get; set; }

        public required DateOnly DataInfiintare { get; set; }

        public required string Nume { get; set; }

        public string? Emblema { get; set; }

        public decimal ValoareEchipa { get; set; }
    }
}