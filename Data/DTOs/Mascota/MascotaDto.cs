namespace API_PetCare_Connect.Data.DTOs.Mascota
{
    public class MascotaDto
    {
        public int IdMascota { get; set; }

        public string NombreMascota { get; set; } = null!;

        public DateOnly? FechaNacimiento { get; set; }

        public string? SexoMascota { get; set; }

        public string? ColorMascota { get; set; }

        public decimal? PesoActual { get; set; }

        public bool? Esterilizado { get; set; }

        public string? EstadoMascota { get; set; }

        public int? IdCliente { get; set; }

        public int? IdEspecie { get; set; }

        public int? IdRaza { get; set; }
    }
}