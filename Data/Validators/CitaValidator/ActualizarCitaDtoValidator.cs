using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Cita;

namespace API_PetCare_Connect.Validators.Cita;

public class ActualizarCitaDtoValidator : AbstractValidator<ActualizarCitaDto>
{
    public ActualizarCitaDtoValidator()
    {
        RuleFor(x => x.FechaCita)
            .NotEmpty();

        RuleFor(x => x.MotivoCita)
            .MaximumLength(200);

        RuleFor(x => x.ObservacionesCita)
            .MaximumLength(500);

        RuleFor(x => x.IdMascota)
            .GreaterThan(0);

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0);

        RuleFor(x => x.IdSede)
            .GreaterThan(0);

        RuleFor(x => x.EstadoCita)
            .Must(x =>
                string.Equals(x, "Programada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Confirmada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Completada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Cancelada", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoCita));
    }
}