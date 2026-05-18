using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Cliente;

namespace API_PetCare_Connect.Validators.Cliente
{
    public class ActualizarClienteDtoValidator : AbstractValidator<ActualizarClienteDto>
    {
        public ActualizarClienteDtoValidator()
        {
            RuleFor(x => x.DniCliente)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.NombreCliente)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.ApellidoCliente)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.TelefonoCliente)
                .MaximumLength(20);

            RuleFor(x => x.CorreoCliente)
                .EmailAddress()
                .When(x => !string.IsNullOrWhiteSpace(x.CorreoCliente));

            RuleFor(x => x.DireccionCliente)
                .MaximumLength(200);

            RuleFor(x => x.EstadoCliente)
                .Must(x =>
                    string.Equals(x, "Activo", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(x, "Inactivo", StringComparison.OrdinalIgnoreCase))
                .When(x => !string.IsNullOrWhiteSpace(x.EstadoCliente));
        }

        
        
    }
}