namespace API_PetCare_Connect.Data.DTOs.Factura;

public class CrearFacturaDto
{
    public DateTime FechaFactura { get; set; }
    public decimal? SubtotalFactura { get; set; }
    public decimal? ImpuestosFactura { get; set; }
    public decimal? TotalFactura { get; set; }
    public int IdCliente { get; set; }
    public int IdEmpleado { get; set; }
    public int IdSede { get; set; }
}