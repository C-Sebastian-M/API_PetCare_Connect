namespace API_PetCare_Connect.DTOs.Consulta
{
    public class ConsultaDetalleDto
    {
        public int IdConsulta { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string? MotivoConsulta { get; set; }

        public string? Sintomas { get; set; }

        public string? DiagnosticoConsulta { get; set; }

        public string? TratamientoConsulta { get; set; }

        public string? ObservacionesConsulta { get; set; }

        public decimal? PesoMascota { get; set; }

        public decimal? TemperaturaMascota { get; set; }

        public int? FrecuenciaCardiaca { get; set; }

        public string NombreMascota { get; set; } = null!;

        public string NombreVeterinario { get; set; } = null!;
    }
}