namespace API_PetCare_Connect.Data.DTOs.Pago;

public class PagoDto
{
    public int IdPago { get; set; }
    public DateTime FechaPago { get; set; }
    public decimal MontoPago { get; set; }
    public string? ReferenciaPago { get; set; }
    public string? ObservacionesPago { get; set; }
    public string? EstadoPago { get; set; }
    public int? IdFactura { get; set; }
    public int? IdMetodoPago { get; set; }
}
