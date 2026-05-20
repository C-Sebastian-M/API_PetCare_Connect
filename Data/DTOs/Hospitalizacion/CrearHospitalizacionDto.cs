namespace API_PetCare_Connect.Data.DTOs.Hospitalizacion;

public class CrearHospitalizacionDto
{
    public DateTime FechaIngreso { get; set; }
    public string? MotivoHospitalizacion { get; set; }
    public string? ObservacionesHospitalizacion { get; set; }
    public int IdMascota { get; set; }
    public int IdJaula { get; set; }
    public int IdEmpleado { get; set; }
}