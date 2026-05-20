namespace API_PetCare_Connect.Data.DTOs.Cita;

public class DetalleCitaDto
{
    public int IdCita { get; set; }
    public DateTime FechaCita { get; set; }
    public TimeOnly? HoraCita { get; set; }
    public string? MotivoCita { get; set; }
    public string? EstadoCita { get; set; }
    public string? ObservacionesCita { get; set; }
    public string NombreMascota { get; set; } = null!;
    public string NombreVeterinario { get; set; } = null!;
    public string NombreSede { get; set; } = null!;
}