namespace API_PetCare_Connect.Data.DTOs.MovimientoInventario;

public class CrearMovimientoInventarioDto
{
    public string? TipoMovimiento { get; set; }
    public int CantidadMovimiento { get; set; }
    public string? MotivoMovimiento { get; set; }
    public int IdProducto { get; set; }
    public int IdSede { get; set; }
    public int IdEmpleado { get; set; }
}
