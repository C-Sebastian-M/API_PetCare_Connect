namespace API_PetCare_Connect.Data.DTOs.Sede;

public class CrearSedeDto
{
    public string NombreSede { get; set; } = null!;
    public string? TelefonoSede { get; set; }
    public string? CorreoSede { get; set; }
    public string? DireccionSede { get; set; }
    public string? CiudadSede { get; set; }
    public DateOnly? FechaApertura { get; set; }
}