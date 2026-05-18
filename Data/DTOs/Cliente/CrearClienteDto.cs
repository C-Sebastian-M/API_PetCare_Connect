namespace API_PetCare_Connect.Data.DTOs.Cliente
{
    public class CrearClienteDto
    {

        public string DniCliente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;
        public string? TelefonoCliente { get; set; }
        public string? CorreoCliente { get; set; }
        public string? DireccionCliente { get; set; }
    }
}