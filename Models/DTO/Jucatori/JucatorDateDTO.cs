namespace AspNetCoreApp.Models.DTO.Jucatori
{
    public class JucatorDateDTO
    {
        public required string Nume { get; set; }

        public required string Prenume { get; set; }

        public int IdTara { get; set; }

        public int IdEchipa { get; set; }

        public int IdPozitie { get; set; }

        public required DateOnly DataNasterii { get; set; }

        public int Salariu { get; set; }
    }
}