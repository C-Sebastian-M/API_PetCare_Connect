using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? DescripcionProducto { get; set; }

    public decimal? PrecioCompra { get; set; }

    public decimal? PrecioVenta { get; set; }

    public int? StockMinimo { get; set; }

    public bool? RequiereFormula { get; set; }

    public string? EstadoProducto { get; set; }

    public int? IdCategoria { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual CategoriaProducto? IdCategoriaNavigation { get; set; }

    public virtual ICollection<InventarioSede> InventarioSedes { get; set; } = new List<InventarioSede>();

    public virtual ICollection<LoteProducto> LoteProductos { get; set; } = new List<LoteProducto>();

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();
}
