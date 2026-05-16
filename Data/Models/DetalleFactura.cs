using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class DetalleFactura
{
    public int IdDetalleFactura { get; set; }

    public int Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public string? TipoItem { get; set; }

    public string? DescripcionItem { get; set; }

    public int? IdFactura { get; set; }

    public int? IdProducto { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
