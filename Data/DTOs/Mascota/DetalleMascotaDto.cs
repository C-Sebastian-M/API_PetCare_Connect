namespace API_PetCare_Connect.DTOs.Mascota
{
    public class MascotaDetalleDto
    {
        public int IdMascota { get; set; }

        public string NombreMascota { get; set; } = null!;

        public DateOnly? FechaNacimiento { get; set; }

        public string? SexoMascota { get; set; }

        public string? ColorMascota { get; set; }

        public decimal? PesoActual { get; set; }

        public bool? Esterilizado { get; set; }

        public string? ObservacionesGenerales { get; set; }

        public string? EstadoMascota { get; set; }

        public string NombreCliente { get; set; } = null!;

        public string NombreEspecie { get; set; } = null!;

        public string NombreRaza { get; set; } = null!;
    }
}