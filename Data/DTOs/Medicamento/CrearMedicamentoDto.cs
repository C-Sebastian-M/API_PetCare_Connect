namespace API_PetCare_Connect.Data.DTOs.Medicamento;

public class CrearMedicamentoDto
{
    public string NombreMedicamento { get; set; } = null!;
    public string? Concentracion { get; set; }
    public string? Presentacion { get; set; }
    public string? Laboratorio { get; set; }
    public DateOnly? FechaVencimiento { get; set; }
    public string? DescripcionMedicamento { get; set; }
    public int IdProducto { get; set; }
}
