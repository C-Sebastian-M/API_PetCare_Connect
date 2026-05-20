namespace API_PetCare_Connect.Data.DTOs.Factura
{
    public class PagoFacturaItemDto
    {
        public int IdPago { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public string? MetodoPago { get; set; }
    }
}
