using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Jaula
{
    public int IdJaula { get; set; }

    public string CodigoJaula { get; set; } = null!;

    public int? Capacidad { get; set; }

    public string? EstadoJaula { get; set; }

    public int? IdSede { get; set; }

    public virtual ICollection<Hospitalizacion> Hospitalizacions { get; set; } = new List<Hospitalizacion>();

    public virtual Sede? IdSedeNavigation { get; set; }
}
