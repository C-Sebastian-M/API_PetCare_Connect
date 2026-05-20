using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Cita;

namespace API_PetCare_Connect.Validators.Cita;

public class CrearCitaDtoValidator : AbstractValidator<CrearCitaDto>
{
    public CrearCitaDtoValidator()
    {
        RuleFor(x => x.FechaCita)
            .NotEmpty()
            .WithMessage("La fecha de la cita es obligatoria.");

        RuleFor(x => x.MotivoCita)
            .MaximumLength(200);

        RuleFor(x => x.ObservacionesCita)
            .MaximumLength(500);

        RuleFor(x => x.IdMascota)
            .GreaterThan(0)
            .WithMessage("La mascota es obligatoria.");

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0)
            .WithMessage("El veterinario es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}