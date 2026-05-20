namespace API_PetCare_Connect.Data.DTOs.Hospitalizacion;

public class DetalleHospitalizacionDto
{
    public int IdHospitalizacion { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime? FechaEgreso { get; set; }
    public string? MotivoHospitalizacion { get; set; }
    public string? EstadoHospitalizacion { get; set; }
    public string? ObservacionesHospitalizacion { get; set; }
    public DateTime FechaRegistroHospitalizacion { get; set; }
    public DateTime? FechaModificacionHospitalizacion { get; set; }
    public string NombreMascota { get; set; } = null!;
    public string CodigoJaula { get; set; } = null!;
    public string NombreVeterinario { get; set; } = null!;
    public List<EvolucionClinicaItemDto> EvolucionClinicas { get; set; } = [];
}