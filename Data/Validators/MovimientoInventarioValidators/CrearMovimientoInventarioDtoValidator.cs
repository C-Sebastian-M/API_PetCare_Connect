using FluentValidation;
using API_PetCare_Connect.Data.DTOs.MovimientoInventario;

namespace API_PetCare_Connect.Validators.MovimientoInventario;

public class CrearMovimientoInventarioDtoValidator : AbstractValidator<CrearMovimientoInventarioDto>
{
    public CrearMovimientoInventarioDtoValidator()
    {
        RuleFor(x => x.TipoMovimiento)
            .NotEmpty()
            .WithMessage("El tipo de movimiento es obligatorio.")
            .Must(x =>
                string.Equals(x, "Entrada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Salida", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Ajuste", StringComparison.OrdinalIgnoreCase))
            .WithMessage("El tipo de movimiento debe ser 'Entrada', 'Salida' o 'Ajuste'.");

        RuleFor(x => x.CantidadMovimiento)
            .GreaterThan(0)
            .WithMessage("La cantidad debe ser mayor a cero.");

        RuleFor(x => x.MotivoMovimiento)
            .MaximumLength(200);

        RuleFor(x => x.IdProducto)
            .GreaterThan(0)
            .WithMessage("El producto es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0)
            .WithMessage("El empleado es obligatorio.");
    }
}
