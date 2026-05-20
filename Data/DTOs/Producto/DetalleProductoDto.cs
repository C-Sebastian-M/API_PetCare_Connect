namespace API_PetCare_Connect.Data.DTOs.Producto;

public class DetalleProductoDto
{
    public int IdProducto { get; set; }
    public string NombreProducto { get; set; } = null!;
    public string? DescripcionProducto { get; set; }
    public decimal? PrecioCompra { get; set; }
    public decimal? PrecioVenta { get; set; }
    public int? StockMinimo { get; set; }
    public bool? RequiereFormula { get; set; }
    public string? EstadoProducto { get; set; }
    public DateTime FechaRegistroProducto { get; set; }
    public DateTime? FechaModificacionProducto { get; set; }
    public string NombreCategoria { get; set; } = null!;
}
