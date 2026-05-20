using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Compra;

namespace API_PetCare_Connect.Validators.Compra;

public class ActualizarCompraDtoValidator : AbstractValidator<ActualizarCompraDto>
{
    public ActualizarCompraDtoValidator()
    {
        RuleFor(x => x.FechaCompra)
            .NotEmpty();

        RuleFor(x => x.NumeroFacturaProveedor)
            .MaximumLength(50);

        RuleFor(x => x.TotalCompra)
            .GreaterThanOrEqualTo(0)
            .When(x => x.TotalCompra.HasValue);

        RuleFor(x => x.IdProveedor)
            .GreaterThan(0);

        RuleFor(x => x.IdSede)
            .GreaterThan(0);

        RuleFor(x => x.EstadoCompra)
            .Must(x =>
                string.Equals(x, "Pendiente", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Completada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Anulada", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoCompra));
    }
}