namespace API_PetCare_Connect.Data.DTOs.Compra;

public class DetalleCompraDto
{
    public int IdCompra { get; set; }
    public DateTime FechaCompra { get; set; }
    public string? NumeroFacturaProveedor { get; set; }
    public decimal? TotalCompra { get; set; }
    public string? EstadoCompra { get; set; }
    public DateTime FechaRegistroCompra { get; set; }
    public DateTime? FechaModificacionCompra { get; set; }
    public string NombreProveedor { get; set; } = null!;
    public string NombreSede { get; set; } = null!;
    public List<DetalleCompraItemDto> DetalleCompras { get; set; } = [];
}
