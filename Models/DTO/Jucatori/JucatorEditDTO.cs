using System.ComponentModel.DataAnnotations;

    public class JucatorEditDTO
    {
        [Key]
        public int IdJucator { get; set; }
        
        public int IdTara { get; set; }

        public int IdEchipa { get; set; }

        public int IdPozitie { get; set; }

        public string? Nume { get; set; }

        public string? Prenume { get; set; }

        public DateOnly DataNasterii { get; set; }

        public int Salariu { get; set; }
    }
