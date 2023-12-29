namespace AspNetCoreApp.Models.DTO.Antrenori
{
    public class AntrenorDateDTO
    {
        public required string Nume { get; set; }

        public required string Prenume { get; set; }

        public int IdTara { get; set; }

        public required DateOnly DataNasterii { get; set; }

    }
}