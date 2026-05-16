using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class EvolucionClinica
{
    public int IdEvolucion { get; set; }

    public DateTime FechaEvolucion { get; set; }

    public string? DescripcionEvolucion { get; set; }

    public string? ObservacionesEvolucion { get; set; }

    public int? IdHospitalizacion { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Hospitalizacion? IdHospitalizacionNavigation { get; set; }
}
