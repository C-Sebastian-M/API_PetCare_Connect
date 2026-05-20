namespace API_PetCare_Connect.Data.DTOs.Factura;

public class DetalleFacturaDto
{
    public int IdFactura { get; set; }
    public DateTime FechaFactura { get; set; }
    public decimal? SubtotalFactura { get; set; }
    public decimal? ImpuestosFactura { get; set; }
    public decimal? TotalFactura { get; set; }
    public string? EstadoFactura { get; set; }
    public DateTime FechaRegistroFactura { get; set; }
    public DateTime? FechaModificacionFactura { get; set; }
    public string NombreCliente { get; set; } = null!;
    public string NombreEmpleado { get; set; } = null!;
    public string NombreSede { get; set; } = null!;
    public List<DetalleFacturaItemDto> DetalleFacturas { get; set; } = [];
    public List<PagoFacturaItemDto> Pagos { get; set; } = [];
}