namespace API_PetCare_Connect.Data.DTOs.Compra
{
    public class DetalleCompraItemDto
    {
        public int IdDetalleCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Subtotal { get; set; }
        public string NombreProducto { get; set; } = null!;
    }
}
