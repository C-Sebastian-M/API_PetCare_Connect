using FluentValidation;
using API_PetCare_Connect.Data.DTOs.InventarioSede;

namespace API_PetCare_Connect.Validators.InventarioSede;

public class ActualizarInventarioSedeDtoValidator : AbstractValidator<ActualizarInventarioSedeDto>
{
    public ActualizarInventarioSedeDtoValidator()
    {
        RuleFor(x => x.StockActual)
            .GreaterThanOrEqualTo(0)
            .WithMessage("El stock no puede ser negativo.");

        RuleFor(x => x.UbicacionProducto)
            .MaximumLength(100);
    }
}
