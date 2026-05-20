namespace API_PetCare_Connect.Data.DTOs.Compra;

public class CompraDto
{
    public int IdCompra { get; set; }
    public DateTime FechaCompra { get; set; }
    public string? NumeroFacturaProveedor { get; set; }
    public decimal? TotalCompra { get; set; }
    public string? EstadoCompra { get; set; }
    public int? IdProveedor { get; set; }
    public int? IdSede { get; set; }
    public DateTime FechaRegistroCompra { get; set; }
    public DateTime? FechaModificacionCompra { get; set; }
}