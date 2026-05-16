using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class VacunaMascotum
{
    public int IdVacunaMascota { get; set; }

    public DateOnly FechaAplicacion { get; set; }

    public DateOnly? ProximaDosis { get; set; }

    public string? DosisAplicada { get; set; }

    public string? Observaciones { get; set; }

    public int IdMascota { get; set; }

    public int IdVacuna { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Mascotum IdMascotaNavigation { get; set; } = null!;

    public virtual Vacuna IdVacunaNavigation { get; set; } = null!;
}
