namespace API_PetCare_Connect.DTOs.Empleado
{
    public class EmpleadoDto
    {
        public int IdEmpleado { get; set; }

        public string DniEmpleado { get; set; } = null!;

        public string NombreEmpleado { get; set; } = null!;

        public string ApellidoEmpleado { get; set; } = null!;

        public string? TelefonoEmpleado { get; set; }

        public string? CorreoEmpleado { get; set; }

        public string? CiudadEmpleado { get; set; }

        public string? EstadoEmpleado { get; set; }

        public DateOnly? FechaContratacion { get; set; }

        public int? IdRol { get; set; }

        public int? IdSede { get; set; }
    }
}