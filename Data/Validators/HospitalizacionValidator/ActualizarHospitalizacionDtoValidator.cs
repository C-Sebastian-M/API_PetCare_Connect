using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Hospitalizacion;

namespace API_PetCare_Connect.Validators.Hospitalizacion;

public class ActualizarHospitalizacionDtoValidator : AbstractValidator<ActualizarHospitalizacionDto>
{
    public ActualizarHospitalizacionDtoValidator()
    {
        RuleFor(x => x.MotivoHospitalizacion)
            .MaximumLength(300);

        RuleFor(x => x.ObservacionesHospitalizacion)
            .MaximumLength(500);

        RuleFor(x => x.IdMascota)
            .GreaterThan(0);

        RuleFor(x => x.IdJaula)
            .GreaterThan(0);

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0);

        RuleFor(x => x.EstadoHospitalizacion)
            .Must(x =>
                string.Equals(x, "Ingresado", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Dado de Alta", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoHospitalizacion));

        RuleFor(x => x.FechaEgreso)
            .GreaterThanOrEqualTo(x => x.FechaIngreso)
            .When(x => x.FechaIngreso.HasValue && x.FechaEgreso.HasValue)
            .WithMessage("La fecha de egreso debe ser posterior o igual a la fecha de ingreso.");
    }
}