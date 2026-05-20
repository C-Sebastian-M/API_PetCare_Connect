using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Jaula;

namespace API_PetCare_Connect.Validators.Jaula;

public class CrearJaulaDtoValidator : AbstractValidator<CrearJaulaDto>
{
    public CrearJaulaDtoValidator()
    {
        RuleFor(x => x.CodigoJaula)
            .NotEmpty()
            .WithMessage("El código de jaula es obligatorio.")
            .MaximumLength(20);

        RuleFor(x => x.Capacidad)
            .GreaterThan(0)
            .When(x => x.Capacidad.HasValue)
            .WithMessage("La capacidad debe ser mayor a cero.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}
