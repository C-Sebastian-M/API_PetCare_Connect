namespace API_PetCare_Connect.Data.DTOs.Compra;

public class ActualizarCompraDto
{
    public DateTime FechaCompra { get; set; }
    public string? NumeroFacturaProveedor { get; set; }
    public decimal? TotalCompra { get; set; }
    public string? EstadoCompra { get; set; }
    public int IdProveedor { get; set; }
    public int IdSede { get; set; }
}