using FluentValidation;
using API_PetCare_Connect.DTOs.Consulta;

namespace API_PetCare_Connect.Validators.Consulta
{
    public class CrearConsultaDtoValidator : AbstractValidator<CrearConsultaDto>
    {
        public CrearConsultaDtoValidator()
        {
            RuleFor(x => x.FechaConsulta)
                .NotEmpty();

            RuleFor(x => x.MotivoConsulta)
                .MaximumLength(500);

            RuleFor(x => x.Sintomas)
                .MaximumLength(1000);

            RuleFor(x => x.DiagnosticoConsulta)
                .MaximumLength(1000);

            RuleFor(x => x.TratamientoConsulta)
                .MaximumLength(1000);

            RuleFor(x => x.ObservacionesConsulta)
                .MaximumLength(1000);

            RuleFor(x => x.PesoMascota)
                .GreaterThan(0)
                .When(x => x.PesoMascota.HasValue);

            RuleFor(x => x.TemperaturaMascota)
                .InclusiveBetween(30, 45)
                .When(x => x.TemperaturaMascota.HasValue)
                .WithMessage("La temperatura debe estar entre 30 y 45.");

            RuleFor(x => x.FrecuenciaCardiaca)
                .GreaterThan(0)
                .When(x => x.FrecuenciaCardiaca.HasValue);

            RuleFor(x => x.IdEmpleado)
                .GreaterThan(0);

            RuleFor(x => x.IdMascota)
                .GreaterThan(0);
        }
    }
}