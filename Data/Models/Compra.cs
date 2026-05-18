using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public DateTime FechaCompra { get; set; }

    public string? NumeroFacturaProveedor { get; set; }

    public decimal? TotalCompra { get; set; }

    public string? EstadoCompra { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdSede { get; set; }

    public DateTime FechaRegistroCompra { get; set; }

    public DateTime? FechaModificacionCompra { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Proveedor? IdProveedorNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }
}
