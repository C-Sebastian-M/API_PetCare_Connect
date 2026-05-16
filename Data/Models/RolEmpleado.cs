using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class RolEmpleado
{
    public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;

    public string? DescripcionRol { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
