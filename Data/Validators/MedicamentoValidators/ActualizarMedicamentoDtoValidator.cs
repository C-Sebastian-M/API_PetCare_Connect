using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Medicamento;

namespace API_PetCare_Connect.Validators.Medicamento;

public class ActualizarMedicamentoDtoValidator : AbstractValidator<ActualizarMedicamentoDto>
{
    public ActualizarMedicamentoDtoValidator()
    {
        RuleFor(x => x.NombreMedicamento)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Concentracion)
            .MaximumLength(50);

        RuleFor(x => x.Presentacion)
            .MaximumLength(50);

        RuleFor(x => x.Laboratorio)
            .MaximumLength(100);

        RuleFor(x => x.DescripcionMedicamento)
            .MaximumLength(300);

        RuleFor(x => x.IdProducto)
            .GreaterThan(0);
    }
}
