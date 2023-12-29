using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApp.Models.Entities
{
    [Table("Locatii")]
    public class Locatie
    {
        [Key]
        public int IdLocatie { get; set; }

        public int IdTara { get; set; }

        public required string Oras { get; set; }

        [ForeignKey("IdTara")]
        public Tara? Tara { get; set; }
    }
}