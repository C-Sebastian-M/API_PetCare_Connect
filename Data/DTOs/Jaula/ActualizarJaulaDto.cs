namespace API_PetCare_Connect.Data.DTOs.Jaula;

public class ActualizarJaulaDto
{
    public string CodigoJaula { get; set; } = null!;
    public int? Capacidad { get; set; }
    public string? EstadoJaula { get; set; }
    public int IdSede { get; set; }
}
