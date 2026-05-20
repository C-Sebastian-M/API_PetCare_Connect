using FluentValidation;
using API_PetCare_Connect.Data.DTOs.LoteProducto;

namespace API_PetCare_Connect.Validators.LoteProducto;

public class CrearLoteProductoDtoValidator : AbstractValidator<CrearLoteProductoDto>
{
    public CrearLoteProductoDtoValidator()
    {
        RuleFor(x => x.CodigoLote)
            .NotEmpty()
            .WithMessage("El código de lote es obligatorio.")
            .MaximumLength(50);

        RuleFor(x => x.CantidadLote)
            .GreaterThan(0)
            .When(x => x.CantidadLote.HasValue)
            .WithMessage("La cantidad debe ser mayor a cero.");

        RuleFor(x => x.IdProducto)
            .GreaterThan(0)
            .WithMessage("El producto es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}
