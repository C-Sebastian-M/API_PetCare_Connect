using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class DetalleCompra
{
    public int IdDetalleCompra { get; set; }

    public int Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public int? IdCompra { get; set; }

    public int? IdProducto { get; set; }

    public virtual Compra? IdCompraNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
