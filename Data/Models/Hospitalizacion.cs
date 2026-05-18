using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Hospitalizacion
{
    public int IdHospitalizacion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public string? MotivoHospitalizacion { get; set; }

    public string? EstadoHospitalizacion { get; set; }

    public string? ObservacionesHospitalizacion { get; set; }

    public int? IdMascota { get; set; }

    public int? IdJaula { get; set; }

    public int? IdEmpleado { get; set; }

    public DateTime FechaRegistroHospitalizacion { get; set; }

    public DateTime? FechaModificacionHospitalizacion { get; set; }

    public virtual ICollection<EvolucionClinica> EvolucionClinicas { get; set; } = new List<EvolucionClinica>();

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Jaula? IdJaulaNavigation { get; set; }

    public virtual Mascotum? IdMascotaNavigation { get; set; }
}
