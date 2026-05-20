namespace API_PetCare_Connect.Data.DTOs.InventarioSede;

public class InventarioSedeDto
{
    public int IdInventarioSede { get; set; }
    public int StockActual { get; set; }
    public string? UbicacionProducto { get; set; }
    public int? IdProducto { get; set; }
    public int? IdSede { get; set; }
}
