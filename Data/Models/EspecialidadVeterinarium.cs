using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class EspecialidadVeterinarium
{
    public int IdEspecialidad { get; set; }

    public string NombreEspecialidad { get; set; } = null!;

    public string? DescripcionEspecialidad { get; set; }

    public virtual ICollection<Empleado> IdEmpleados { get; set; } = new List<Empleado>();
}
