using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Producto;

namespace API_PetCare_Connect.Validators.Producto;

public class ActualizarProductoDtoValidator : AbstractValidator<ActualizarProductoDto>
{
    public ActualizarProductoDtoValidator()
    {
        RuleFor(x => x.NombreProducto)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.DescripcionProducto)
            .MaximumLength(300);

        RuleFor(x => x.PrecioCompra)
            .GreaterThanOrEqualTo(0)
            .When(x => x.PrecioCompra.HasValue);

        RuleFor(x => x.PrecioVenta)
            .GreaterThanOrEqualTo(0)
            .When(x => x.PrecioVenta.HasValue);

        RuleFor(x => x.StockMinimo)
            .GreaterThanOrEqualTo(0)
            .When(x => x.StockMinimo.HasValue);

        RuleFor(x => x.IdCategoria)
            .GreaterThan(0);

        RuleFor(x => x.EstadoProducto)
            .Must(x =>
                string.Equals(x, "Activo", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Inactivo", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoProducto));
    }
}
