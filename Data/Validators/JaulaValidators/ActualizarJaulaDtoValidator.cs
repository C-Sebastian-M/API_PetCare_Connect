using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Jaula;

namespace API_PetCare_Connect.Validators.Jaula;

public class ActualizarJaulaDtoValidator : AbstractValidator<ActualizarJaulaDto>
{
    public ActualizarJaulaDtoValidator()
    {
        RuleFor(x => x.CodigoJaula)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(x => x.Capacidad)
            .GreaterThan(0)
            .When(x => x.Capacidad.HasValue);

        RuleFor(x => x.IdSede)
            .GreaterThan(0);

        RuleFor(x => x.EstadoJaula)
            .Must(x =>
                string.Equals(x, "Disponible", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Ocupada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Mantenimiento", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoJaula));
    }
}
