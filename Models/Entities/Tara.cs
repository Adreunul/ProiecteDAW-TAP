using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApp.Models.Entities
{
    [Table("Tari")]
    public class Tara
    {
        [Key]
        public int IdTara { get; set; }
        public required string Denumire { get; set; }
    }
}