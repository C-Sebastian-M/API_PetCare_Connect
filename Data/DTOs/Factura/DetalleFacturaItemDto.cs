namespace API_PetCare_Connect.Data.DTOs.Factura
{
    public class DetalleFacturaItemDto
    {
        public int IdDetalleFactura { get; set; }
        public int Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Subtotal { get; set; }
        public string? TipoItem { get; set; }
        public string? DescripcionItem { get; set; }
        public string NombreProducto { get; set; } = null!;
    }

}
