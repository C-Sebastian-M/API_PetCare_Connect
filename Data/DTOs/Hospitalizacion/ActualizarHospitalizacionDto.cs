namespace API_PetCare_Connect.Data.DTOs.Hospitalizacion;

public class ActualizarHospitalizacionDto
{
    public DateTime? FechaIngreso { get; set; }
    public DateTime? FechaEgreso { get; set; }
    public string? MotivoHospitalizacion { get; set; }
    public string? EstadoHospitalizacion { get; set; }
    public string? ObservacionesHospitalizacion { get; set; }
    public int IdMascota { get; set; }
    public int IdJaula { get; set; }
    public int IdEmpleado { get; set; }
}