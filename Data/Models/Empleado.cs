using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string DniEmpleado { get; set; } = null!;

    public string NombreEmpleado { get; set; } = null!;

    public string ApellidoEmpleado { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string? TelefonoEmpleado { get; set; }

    public string? CorreoEmpleado { get; set; }

    public string? DireccionEmpleado { get; set; }

    public string? CiudadEmpleado { get; set; }

    public string? EstadoEmpleado { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public DateOnly? FechaRetiro { get; set; }

    public int? IdRol { get; set; }

    public int? IdSede { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual ICollection<EvolucionClinica> EvolucionClinicas { get; set; } = new List<EvolucionClinica>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Hospitalizacion> Hospitalizacions { get; set; } = new List<Hospitalizacion>();

    public virtual RolEmpleado? IdRolNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<VacunaMascotum> VacunaMascota { get; set; } = new List<VacunaMascotum>();

    public virtual ICollection<EspecialidadVeterinarium> IdEspecialidads { get; set; } = new List<EspecialidadVeterinarium>();
}
