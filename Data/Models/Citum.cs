using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Citum
{
    public int IdCita { get; set; }

    public DateTime FechaCita { get; set; }

    public TimeOnly? HoraCita { get; set; }

    public string? MotivoCita { get; set; }

    public string? EstadoCita { get; set; }

    public string? ObservacionesCita { get; set; }

    public int? IdMascota { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdSede { get; set; }

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Mascotum? IdMascotaNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }
}
