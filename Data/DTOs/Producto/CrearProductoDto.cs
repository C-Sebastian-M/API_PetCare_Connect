namespace API_PetCare_Connect.Data.DTOs.Producto;

public class CrearProductoDto
{
    public string NombreProducto { get; set; } = null!;
    public string? DescripcionProducto { get; set; }
    public decimal? PrecioCompra { get; set; }
    public decimal? PrecioVenta { get; set; }
    public int? StockMinimo { get; set; }
    public bool? RequiereFormula { get; set; }
    public int IdCategoria { get; set; }
}
