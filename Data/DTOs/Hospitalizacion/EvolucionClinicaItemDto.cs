namespace API_PetCare_Connect.Data.DTOs.Hospitalizacion
{
    public class EvolucionClinicaItemDto
    {
        public int IdEvolucion { get; set; }
        public DateTime FechaEvolucion { get; set; }
        public string? DescripcionEvolucion { get; set; }
        public string? ObservacionesEvolucion { get; set; }
        public string NombreVeterinario { get; set; } = null!;
    }
}
