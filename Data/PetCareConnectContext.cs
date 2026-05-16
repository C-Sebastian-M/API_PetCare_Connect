using System;
using System.Collections.Generic;
using API_PetCare_Connect.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PetCare_Connect.Data;

public partial class PetCareConnectContext : DbContext
{
    public PetCareConnectContext()
    {
    }

    public PetCareConnectContext(DbContextOptions<PetCareConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alergium> Alergia { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<ConsultaTratamiento> ConsultaTratamientos { get; set; }

    public virtual DbSet<Consultum> Consulta { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Diagnostico> Diagnosticos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EspecialidadVeterinarium> EspecialidadVeterinaria { get; set; }

    public virtual DbSet<Especie> Especies { get; set; }

    public virtual DbSet<EvolucionClinica> EvolucionClinicas { get; set; }

    public virtual DbSet<Examan> Examen { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Hospitalizacion> Hospitalizacions { get; set; }

    public virtual DbSet<InventarioSede> InventarioSedes { get; set; }

    public virtual DbSet<Jaula> Jaulas { get; set; }

    public virtual DbSet<LoteProducto> LoteProductos { get; set; }

    public virtual DbSet<MascotaAlergium> MascotaAlergia { get; set; }

    public virtual DbSet<Mascotum> Mascota { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<MovimientoInventario> MovimientoInventarios { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Raza> Razas { get; set; }

    public virtual DbSet<ResultadoExaman> ResultadoExamen { get; set; }

    public virtual DbSet<RolEmpleado> RolEmpleados { get; set; }

    public virtual DbSet<Sede> Sedes { get; set; }

    public virtual DbSet<Tratamiento> Tratamientos { get; set; }

    public virtual DbSet<Vacuna> Vacunas { get; set; }

    public virtual DbSet<VacunaMascotum> VacunaMascota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:SqlConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alergium>(entity =>
        {
            entity.HasKey(e => e.IdAlergia).HasName("PK__Alergia__3D552FE18AA8DB80");

            entity.Property(e => e.IdAlergia).HasColumnName("id_alergia");
            entity.Property(e => e.DescripcionAlergia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_alergia");
            entity.Property(e => e.NombreAlergia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_alergia");
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CD54BC5AB7644C91");

            entity.ToTable("CategoriaProducto");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_categoria");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_categoria");
        });

        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.IdCita).HasName("PK__Cita__6AEC3C0913775713");

            entity.HasIndex(e => e.EstadoCita, "idx_cita_estado");

            entity.HasIndex(e => e.FechaCita, "idx_cita_fecha");

            entity.Property(e => e.IdCita).HasColumnName("id_cita");
            entity.Property(e => e.EstadoCita)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_cita");
            entity.Property(e => e.FechaCita)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cita");
            entity.Property(e => e.HoraCita).HasColumnName("hora_cita");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.MotivoCita)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("motivo_cita");
            entity.Property(e => e.ObservacionesCita)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_cita");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Cita__id_emplead__7E37BEF6");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdMascota)
                .HasConstraintName("FK__Cita__id_mascota__7D439ABD");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Cita__id_sede__7F2BE32F");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__677F38F5EB732D99");

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.DniCliente, "UQ__Cliente__F53D4BA4FE2F3F4A").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_cliente");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo_cliente");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion_cliente");
            entity.Property(e => e.DniCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni_cliente");
            entity.Property(e => e.EstadoCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_cliente");
            entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_cliente");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.IdCompra).HasName("PK__Compra__C4BAA604D4B4C550");

            entity.ToTable("Compra");

            entity.Property(e => e.IdCompra).HasColumnName("id_compra");
            entity.Property(e => e.EstadoCompra)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_compra");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.NumeroFacturaProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_factura_proveedor");
            entity.Property(e => e.TotalCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_compra");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__Compra__id_prove__3C34F16F");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Compra__id_sede__3D2915A8");
        });

        modelBuilder.Entity<ConsultaTratamiento>(entity =>
        {
            entity.HasKey(e => new { e.IdConsulta, e.IdTratamiento }).HasName("PK__Consulta__B3DB7D7F5A7B47CC");

            entity.ToTable("ConsultaTratamiento");

            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.DuracionDias).HasColumnName("duracion_dias");
            entity.Property(e => e.Indicaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("indicaciones");

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.ConsultaTratamientos)
                .HasForeignKey(d => d.IdConsulta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ConsultaT__id_co__114A936A");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.ConsultaTratamientos)
                .HasForeignKey(d => d.IdTratamiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ConsultaT__id_tr__123EB7A3");
        });

        modelBuilder.Entity<Consultum>(entity =>
        {
            entity.HasKey(e => e.IdConsulta).HasName("PK__Consulta__6F53588BA85D51F4");

            entity.HasIndex(e => e.FechaConsulta, "idx_consulta_fecha");

            entity.HasIndex(e => e.IdMascota, "idx_consulta_mascota");

            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.DiagnosticoConsulta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("diagnostico_consulta");
            entity.Property(e => e.FechaConsulta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_consulta");
            entity.Property(e => e.FrecuenciaCardiaca).HasColumnName("frecuencia_cardiaca");
            entity.Property(e => e.IdCita).HasColumnName("id_cita");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.MotivoConsulta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("motivo_consulta");
            entity.Property(e => e.ObservacionesConsulta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_consulta");
            entity.Property(e => e.PesoMascota)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("peso_mascota");
            entity.Property(e => e.Sintomas)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sintomas");
            entity.Property(e => e.TemperaturaMascota)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("temperatura_mascota");
            entity.Property(e => e.TratamientoConsulta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tratamiento_consulta");

            entity.HasOne(d => d.IdCitaNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdCita)
                .HasConstraintName("FK__Consulta__id_cit__03F0984C");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Consulta__id_emp__04E4BC85");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdMascota)
                .HasConstraintName("FK__Consulta__id_mas__05D8E0BE");

            entity.HasMany(d => d.IdDiagnosticos).WithMany(p => p.IdConsulta)
                .UsingEntity<Dictionary<string, object>>(
                    "ConsultaDiagnostico",
                    r => r.HasOne<Diagnostico>().WithMany()
                        .HasForeignKey("IdDiagnostico")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ConsultaD__id_di__0B91BA14"),
                    l => l.HasOne<Consultum>().WithMany()
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ConsultaD__id_co__0A9D95DB"),
                    j =>
                    {
                        j.HasKey("IdConsulta", "IdDiagnostico").HasName("PK__Consulta__2E6B13FFA9BD8A6A");
                        j.ToTable("ConsultaDiagnostico");
                        j.IndexerProperty<int>("IdConsulta").HasColumnName("id_consulta");
                        j.IndexerProperty<int>("IdDiagnostico").HasColumnName("id_diagnostico");
                    });
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.IdDetalleCompra).HasName("PK__DetalleC__BD16E279E78B8FE5");

            entity.ToTable("DetalleCompra");

            entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdCompra).HasColumnName("id_compra");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_unitario");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdCompraNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdCompra)
                .HasConstraintName("FK__DetalleCo__id_co__42E1EEFE");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__DetalleCo__id_pr__43D61337");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalleFactura).HasName("PK__DetalleF__F6BFE343176B659E");

            entity.ToTable("DetalleFactura");

            entity.Property(e => e.IdDetalleFactura).HasColumnName("id_detalle_factura");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescripcionItem)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_item");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_unitario");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.TipoItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_item");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__DetalleFa__id_fa__662B2B3B");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__DetalleFa__id_pr__671F4F74");
        });

        modelBuilder.Entity<Diagnostico>(entity =>
        {
            entity.HasKey(e => e.IdDiagnostico).HasName("PK__Diagnost__1384B7459C2903AF");

            entity.ToTable("Diagnostico");

            entity.Property(e => e.IdDiagnostico).HasColumnName("id_diagnostico");
            entity.Property(e => e.DescripcionDiagnostico)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_diagnostico");
            entity.Property(e => e.NombreDiagnostico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_diagnostico");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__88B513942D92A24B");

            entity.ToTable("Empleado");

            entity.HasIndex(e => e.DniEmpleado, "UQ__Empleado__0FA5136FB933E338").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.ApellidoEmpleado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_empleado");
            entity.Property(e => e.CiudadEmpleado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad_empleado");
            entity.Property(e => e.CorreoEmpleado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo_empleado");
            entity.Property(e => e.DireccionEmpleado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion_empleado");
            entity.Property(e => e.DniEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dni_empleado");
            entity.Property(e => e.EstadoEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_empleado");
            entity.Property(e => e.FechaContratacion).HasColumnName("fecha_contratacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.FechaRetiro).HasColumnName("fecha_retiro");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_empleado");
            entity.Property(e => e.TelefonoEmpleado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_empleado");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Empleado__id_rol__5441852A");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Empleado__id_sed__5535A963");

            entity.HasMany(d => d.IdEspecialidads).WithMany(p => p.IdEmpleados)
                .UsingEntity<Dictionary<string, object>>(
                    "EmpleadoEspecialidad",
                    r => r.HasOne<EspecialidadVeterinarium>().WithMany()
                        .HasForeignKey("IdEspecialidad")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__EmpleadoE__id_es__5AEE82B9"),
                    l => l.HasOne<Empleado>().WithMany()
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__EmpleadoE__id_em__59FA5E80"),
                    j =>
                    {
                        j.HasKey("IdEmpleado", "IdEspecialidad").HasName("PK__Empleado__A4A800E24E68BD41");
                        j.ToTable("EmpleadoEspecialidad");
                        j.IndexerProperty<int>("IdEmpleado").HasColumnName("id_empleado");
                        j.IndexerProperty<int>("IdEspecialidad").HasColumnName("id_especialidad");
                    });
        });

        modelBuilder.Entity<EspecialidadVeterinarium>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad).HasName("PK__Especial__C1D13763E6DF23A2");

            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");
            entity.Property(e => e.DescripcionEspecialidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_especialidad");
            entity.Property(e => e.NombreEspecialidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_especialidad");
        });

        modelBuilder.Entity<Especie>(entity =>
        {
            entity.HasKey(e => e.IdEspecie).HasName("PK__Especie__96DDB0B915B0E270");

            entity.ToTable("Especie");

            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");
            entity.Property(e => e.NombreEspecie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_especie");
        });

        modelBuilder.Entity<EvolucionClinica>(entity =>
        {
            entity.HasKey(e => e.IdEvolucion).HasName("PK__Evolucio__8D02E960196FBDBB");

            entity.ToTable("EvolucionClinica");

            entity.Property(e => e.IdEvolucion).HasColumnName("id_evolucion");
            entity.Property(e => e.DescripcionEvolucion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion_evolucion");
            entity.Property(e => e.FechaEvolucion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_evolucion");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdHospitalizacion).HasColumnName("id_hospitalizacion");
            entity.Property(e => e.ObservacionesEvolucion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_evolucion");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.EvolucionClinicas)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Evolucion__id_em__282DF8C2");

            entity.HasOne(d => d.IdHospitalizacionNavigation).WithMany(p => p.EvolucionClinicas)
                .HasForeignKey(d => d.IdHospitalizacion)
                .HasConstraintName("FK__Evolucion__id_ho__2739D489");
        });

        modelBuilder.Entity<Examan>(entity =>
        {
            entity.HasKey(e => e.IdExamen).HasName("PK__Examen__D16A231D1ABF3B79");

            entity.Property(e => e.IdExamen).HasColumnName("id_examen");
            entity.Property(e => e.CostoExamen)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("costo_examen");
            entity.Property(e => e.DescripcionExamen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_examen");
            entity.Property(e => e.NombreExamen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_examen");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__6C08ED53FCD4194C");

            entity.ToTable("Factura");

            entity.HasIndex(e => e.IdCliente, "idx_factura_cliente");

            entity.HasIndex(e => e.EstadoFactura, "idx_factura_estado");

            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.EstadoFactura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_factura");
            entity.Property(e => e.FechaFactura)
                .HasColumnType("datetime")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.ImpuestosFactura)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("impuestos_factura");
            entity.Property(e => e.SubtotalFactura)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal_factura");
            entity.Property(e => e.TotalFactura)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_factura");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Factura__id_clie__5D95E53A");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Factura__id_empl__5E8A0973");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Factura__id_sede__5F7E2DAC");
        });

        modelBuilder.Entity<Hospitalizacion>(entity =>
        {
            entity.HasKey(e => e.IdHospitalizacion).HasName("PK__Hospital__43CC8A3353321042");

            entity.ToTable("Hospitalizacion");

            entity.HasIndex(e => e.EstadoHospitalizacion, "idx_hospitalizacion_estado");

            entity.Property(e => e.IdHospitalizacion).HasColumnName("id_hospitalizacion");
            entity.Property(e => e.EstadoHospitalizacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_hospitalizacion");
            entity.Property(e => e.FechaEgreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_egreso");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdJaula).HasColumnName("id_jaula");
            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.MotivoHospitalizacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("motivo_hospitalizacion");
            entity.Property(e => e.ObservacionesHospitalizacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_hospitalizacion");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Hospitalizacions)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Hospitali__id_em__245D67DE");

            entity.HasOne(d => d.IdJaulaNavigation).WithMany(p => p.Hospitalizacions)
                .HasForeignKey(d => d.IdJaula)
                .HasConstraintName("FK__Hospitali__id_ja__236943A5");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.Hospitalizacions)
                .HasForeignKey(d => d.IdMascota)
                .HasConstraintName("FK__Hospitali__id_ma__22751F6C");
        });

        modelBuilder.Entity<InventarioSede>(entity =>
        {
            entity.HasKey(e => e.IdInventarioSede).HasName("PK__Inventar__F9D92B18DCA08DC7");

            entity.ToTable("InventarioSede");

            entity.HasIndex(e => new { e.IdSede, e.IdProducto }, "idx_inventario_sede");

            entity.Property(e => e.IdInventarioSede).HasColumnName("id_inventario_sede");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.StockActual).HasColumnName("stock_actual");
            entity.Property(e => e.UbicacionProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ubicacion_producto");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.InventarioSedes)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Inventari__id_pr__4D5F7D71");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.InventarioSedes)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Inventari__id_se__4E53A1AA");
        });

        modelBuilder.Entity<Jaula>(entity =>
        {
            entity.HasKey(e => e.IdJaula).HasName("PK__Jaula__2514BFD9DF40DD6C");

            entity.ToTable("Jaula");

            entity.HasIndex(e => e.CodigoJaula, "UQ__Jaula__16CD643745CEF235").IsUnique();

            entity.Property(e => e.IdJaula).HasColumnName("id_jaula");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.CodigoJaula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codigo_jaula");
            entity.Property(e => e.EstadoJaula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_jaula");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.Jaulas)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Jaula__id_sede__1EA48E88");
        });

        modelBuilder.Entity<LoteProducto>(entity =>
        {
            entity.HasKey(e => e.IdLote).HasName("PK__LoteProd__9A0004866ACEEC1A");

            entity.ToTable("LoteProducto");

            entity.Property(e => e.IdLote).HasColumnName("id_lote");
            entity.Property(e => e.CantidadLote).HasColumnName("cantidad_lote");
            entity.Property(e => e.CodigoLote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_lote");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.LoteProductos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__LoteProdu__id_pr__47A6A41B");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.LoteProductos)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__LoteProdu__id_se__489AC854");
        });

        modelBuilder.Entity<MascotaAlergium>(entity =>
        {
            entity.HasKey(e => new { e.IdMascota, e.IdAlergia }).HasName("PK__MascotaA__6CD621AC3D7AB147");

            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.IdAlergia).HasColumnName("id_alergia");
            entity.Property(e => e.NivelGravedad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nivel_gravedad");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdAlergiaNavigation).WithMany(p => p.MascotaAlergia)
                .HasForeignKey(d => d.IdAlergia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MascotaAl__id_al__797309D9");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.MascotaAlergia)
                .HasForeignKey(d => d.IdMascota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MascotaAl__id_ma__787EE5A0");
        });

        modelBuilder.Entity<Mascotum>(entity =>
        {
            entity.HasKey(e => e.IdMascota).HasName("PK__Mascota__6F03735278A6C444");

            entity.HasIndex(e => e.IdCliente, "idx_mascota_cliente");

            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.ColorMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color_mascota");
            entity.Property(e => e.EstadoMascota)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_mascota");
            entity.Property(e => e.Esterilizado).HasColumnName("esterilizado");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");
            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_mascota");
            entity.Property(e => e.ObservacionesGenerales)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_generales");
            entity.Property(e => e.PesoActual)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("peso_actual");
            entity.Property(e => e.SexoMascota)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sexo_mascota");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Mascota__id_clie__6B24EA82");

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdEspecie)
                .HasConstraintName("FK__Mascota__id_espe__6C190EBB");

            entity.HasOne(d => d.IdRazaNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdRaza)
                .HasConstraintName("FK__Mascota__id_raza__6A30C649");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.IdMedicamento).HasName("PK__Medicame__2588C03293F9CFD8");

            entity.ToTable("Medicamento");

            entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");
            entity.Property(e => e.Concentracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("concentracion");
            entity.Property(e => e.DescripcionMedicamento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_medicamento");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.Laboratorio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("laboratorio");
            entity.Property(e => e.NombreMedicamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_medicamento");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("presentacion");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Medicamen__id_pr__339FAB6E");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK__MetodoPa__85BE0EBCA80ED30B");

            entity.ToTable("MetodoPago");

            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.DescripcionMetodoPago)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_metodo_pago");
            entity.Property(e => e.NombreMetodoPago)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_metodo_pago");
        });

        modelBuilder.Entity<MovimientoInventario>(entity =>
        {
            entity.HasKey(e => e.IdMovimiento).HasName("PK__Movimien__2A071C244554E167");

            entity.ToTable("MovimientoInventario");

            entity.HasIndex(e => e.FechaMovimiento, "idx_movimiento_fecha");

            entity.Property(e => e.IdMovimiento).HasColumnName("id_movimiento");
            entity.Property(e => e.CantidadMovimiento).HasColumnName("cantidad_movimiento");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_movimiento");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.MotivoMovimiento)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("motivo_movimiento");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_movimiento");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Movimient__id_em__55009F39");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Movimient__id_pr__531856C7");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK__Movimient__id_se__540C7B00");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK__Pago__0941B074951178A2");

            entity.ToTable("Pago");

            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_pago");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.MontoPago)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_pago");
            entity.Property(e => e.ObservacionesPago)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones_pago");
            entity.Property(e => e.ReferenciaPago)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("referencia_pago");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__Pago__id_factura__6BE40491");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdMetodoPago)
                .HasConstraintName("FK__Pago__id_metodo___6CD828CA");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__FF341C0DE76FEC1E");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_producto");
            entity.Property(e => e.EstadoProducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_producto");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_compra");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.RequiereFormula).HasColumnName("requiere_formula");
            entity.Property(e => e.StockMinimo).HasColumnName("stock_minimo");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Producto__id_cat__30C33EC3");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE285481D0A9");

            entity.ToTable("Proveedor");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.CiudadProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad_proveedor");
            entity.Property(e => e.CorreoProveedor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo_proveedor");
            entity.Property(e => e.DireccionProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion_proveedor");
            entity.Property(e => e.EstadoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_proveedor");
            entity.Property(e => e.NombreContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_contacto");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_proveedor");
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_contacto");
            entity.Property(e => e.TelefonoProveedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_proveedor");
        });

        modelBuilder.Entity<Raza>(entity =>
        {
            entity.HasKey(e => e.IdRaza).HasName("PK__Raza__084F250AEE2EA0D6");

            entity.ToTable("Raza");

            entity.Property(e => e.IdRaza).HasColumnName("id_raza");
            entity.Property(e => e.DescripcionRaza)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_raza");
            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");
            entity.Property(e => e.NombreRaza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_raza");

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.Razas)
                .HasForeignKey(d => d.IdEspecie)
                .HasConstraintName("FK__Raza__id_especie__6477ECF3");
        });

        modelBuilder.Entity<ResultadoExaman>(entity =>
        {
            entity.HasKey(e => e.IdResultadoExamen).HasName("PK__Resultad__383E111430D6C0A6");

            entity.Property(e => e.IdResultadoExamen).HasColumnName("id_resultado_examen");
            entity.Property(e => e.FechaResultado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_resultado");
            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.IdExamen).HasColumnName("id_examen");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.ResultadoExamen)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("resultado_examen");

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.ResultadoExamen)
                .HasForeignKey(d => d.IdConsulta)
                .HasConstraintName("FK__Resultado__id_co__18EBB532");

            entity.HasOne(d => d.IdExamenNavigation).WithMany(p => p.ResultadoExamen)
                .HasForeignKey(d => d.IdExamen)
                .HasConstraintName("FK__Resultado__id_ex__17F790F9");
        });

        modelBuilder.Entity<RolEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__RolEmple__6ABCB5E0CA5E6D9A");

            entity.ToTable("RolEmpleado");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.DescripcionRol)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_rol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_rol");
        });

        modelBuilder.Entity<Sede>(entity =>
        {
            entity.HasKey(e => e.IdSede).HasName("PK__Sede__D693504B0234EB33");

            entity.ToTable("Sede");

            entity.Property(e => e.IdSede).HasColumnName("id_sede");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.CiudadSede)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad_sede");
            entity.Property(e => e.CorreoSede)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("correo_sede");
            entity.Property(e => e.DireccionSede)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion_sede");
            entity.Property(e => e.EstadoSede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_sede");
            entity.Property(e => e.FechaApertura).HasColumnName("fecha_apertura");
            entity.Property(e => e.NombreSede)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_sede");
            entity.Property(e => e.TelefonoSede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono_sede");
        });

        modelBuilder.Entity<Tratamiento>(entity =>
        {
            entity.HasKey(e => e.IdTratamiento).HasName("PK__Tratamie__C8825F4C96CC7814");

            entity.ToTable("Tratamiento");

            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.DescripcionTratamiento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_tratamiento");
            entity.Property(e => e.NombreTratamiento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_tratamiento");
        });

        modelBuilder.Entity<Vacuna>(entity =>
        {
            entity.HasKey(e => e.IdVacuna).HasName("PK__Vacuna__BCC290CBFB379607");

            entity.ToTable("Vacuna");

            entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");
            entity.Property(e => e.DescripcionVacuna)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion_vacuna");
            entity.Property(e => e.DosisRecomendada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dosis_recomendada");
            entity.Property(e => e.FrecuenciaAplicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("frecuencia_aplicacion");
            entity.Property(e => e.NombreVacuna)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_vacuna");
        });

        modelBuilder.Entity<VacunaMascotum>(entity =>
        {
            entity.HasKey(e => e.IdVacunaMascota).HasName("PK__VacunaMa__AD0F2C32804D7F28");

            entity.HasIndex(e => e.IdMascota, "idx_vacuna_mascota");

            entity.Property(e => e.IdVacunaMascota).HasColumnName("id_vacuna_mascota");
            entity.Property(e => e.DosisAplicada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dosis_aplicada");
            entity.Property(e => e.FechaAplicacion).HasColumnName("fecha_aplicacion");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
            entity.Property(e => e.IdMascota).HasColumnName("id_mascota");
            entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.ProximaDosis).HasColumnName("proxima_dosis");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.VacunaMascota)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__VacunaMas__id_em__72C60C4A");

            entity.HasOne(d => d.IdMascotaNavigation).WithMany(p => p.VacunaMascota)
                .HasForeignKey(d => d.IdMascota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VacunaMas__id_ma__70DDC3D8");

            entity.HasOne(d => d.IdVacunaNavigation).WithMany(p => p.VacunaMascota)
                .HasForeignKey(d => d.IdVacuna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VacunaMas__id_va__71D1E811");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
