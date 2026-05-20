namespace API_PetCare_Connect.Data.DTOs.Compra;

public class CrearCompraDto
{
    public DateTime FechaCompra { get; set; }
    public string? NumeroFacturaProveedor { get; set; }
    public decimal? TotalCompra { get; set; }
    public int IdProveedor { get; set; }
    public int IdSede { get; set; }
}