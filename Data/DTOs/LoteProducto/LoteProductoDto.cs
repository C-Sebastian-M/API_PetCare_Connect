namespace API_PetCare_Connect.Data.DTOs.LoteProducto;

public class LoteProductoDto
{
    public int IdLote { get; set; }
    public string CodigoLote { get; set; } = null!;
    public DateOnly? FechaVencimiento { get; set; }
    public int? CantidadLote { get; set; }
    public int? IdProducto { get; set; }
    public int? IdSede { get; set; }
}
