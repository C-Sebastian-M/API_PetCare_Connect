namespace API_PetCare_Connect.Data.DTOs.Pago;

public class CrearPagoDto
{
    public decimal MontoPago { get; set; }
    public string? ReferenciaPago { get; set; }
    public string? ObservacionesPago { get; set; }
    public int IdFactura { get; set; }
    public int IdMetodoPago { get; set; }
}
