using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Hospitalizacion;

namespace API_PetCare_Connect.Validators.Hospitalizacion;

public class CrearHospitalizacionDtoValidator : AbstractValidator<CrearHospitalizacionDto>
{
    public CrearHospitalizacionDtoValidator()
    {
        RuleFor(x => x.FechaIngreso)
            .NotEmpty()
            .WithMessage("La fecha de ingreso es obligatoria.");

        RuleFor(x => x.MotivoHospitalizacion)
            .NotEmpty()
            .WithMessage("El motivo de hospitalización es obligatorio.")
            .MaximumLength(300);

        RuleFor(x => x.ObservacionesHospitalizacion)
            .MaximumLength(500);

        RuleFor(x => x.IdMascota)
            .GreaterThan(0)
            .WithMessage("La mascota es obligatoria.");

        RuleFor(x => x.IdJaula)
            .GreaterThan(0)
            .WithMessage("La jaula es obligatoria.");

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0)
            .WithMessage("El veterinario es obligatorio.");
    }
}