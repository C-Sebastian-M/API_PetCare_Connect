using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class LoteProducto
{
    public int IdLote { get; set; }

    public string CodigoLote { get; set; } = null!;

    public DateOnly? FechaVencimiento { get; set; }

    public int? CantidadLote { get; set; }

    public int? IdProducto { get; set; }

    public int? IdSede { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }
}
