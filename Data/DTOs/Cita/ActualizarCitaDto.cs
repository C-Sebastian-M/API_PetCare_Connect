namespace API_PetCare_Connect.Data.DTOs.Cita;

public class ActualizarCitaDto
{
    public DateTime FechaCita { get; set; }
    public TimeOnly? HoraCita { get; set; }
    public string? MotivoCita { get; set; }
    public string? EstadoCita { get; set; }
    public string? ObservacionesCita { get; set; }
    public int IdMascota { get; set; }
    public int IdEmpleado { get; set; }
    public int IdSede { get; set; }
}