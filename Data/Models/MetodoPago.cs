using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string NombreMetodoPago { get; set; } = null!;

    public string? DescripcionMetodoPago { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
