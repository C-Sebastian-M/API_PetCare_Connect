namespace API_PetCare_Connect.Data.DTOs.Empleado;

public class DetalleEmpleadoDto
{
    public int IdEmpleado { get; set; }
    public string DniEmpleado { get; set; } = null!;
    public string NombreEmpleado { get; set; } = null!;
    public string ApellidoEmpleado { get; set; } = null!;
    public DateOnly? FechaNacimiento { get; set; }
    public string? TelefonoEmpleado { get; set; }
    public string? CorreoEmpleado { get; set; }
    public string? DireccionEmpleado { get; set; }
    public string? CiudadEmpleado { get; set; }
    public string? EstadoEmpleado { get; set; }
    public DateOnly? FechaContratacion { get; set; }
    public DateOnly? FechaRetiro { get; set; }
    public string NombreRol { get; set; } = null!;
    public string NombreSede { get; set; } = null!;
}
