using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class InventarioSede
{
    public int IdInventarioSede { get; set; }

    public int StockActual { get; set; }

    public string? UbicacionProducto { get; set; }

    public int? IdProducto { get; set; }

    public int? IdSede { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }
}
