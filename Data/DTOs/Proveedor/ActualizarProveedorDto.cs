namespace API_PetCare_Connect.Data.DTOs.Proveedor;

public class ActualizarProveedorDto
{
    public string NombreProveedor { get; set; } = null!;
    public string? TelefonoProveedor { get; set; }
    public string? CorreoProveedor { get; set; }
    public string? DireccionProveedor { get; set; }
    public string? CiudadProveedor { get; set; }
    public string? EstadoProveedor { get; set; }
    public string? NombreContacto { get; set; }
    public string? TelefonoContacto { get; set; }
}