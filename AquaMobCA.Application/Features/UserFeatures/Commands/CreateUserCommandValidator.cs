using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces;
using Domain.Entities;
using FluentValidation;

namespace Application.Features.UserFeatures.Commands
{
    
        public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
        {
            public CreateUserCommandValidator()
            {
                RuleFor(u => u.NIF).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull().MaximumLength(15)
                    .WithMessage("{PropertyName} no debe exceder de 15 caracteres!");
                RuleFor(u => u.Nombre).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull()
                    .MaximumLength(25).WithMessage("{PropertyName} no debe exceder de 25 caracteres!");
                RuleFor(u => u.Apellidos).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull()
                    .MaximumLength(50).WithMessage("{PropertyName} no debe exceder de 50 caracteres!");
                RuleFor(u => u.Direccion).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull()
                    .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de 100 caracteres!");
                RuleFor(u => u.Movil).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull().MaximumLength(25)
                    .WithMessage("{PropertyName} no debe exceder de 25 caracteres!");
                RuleFor(u => u.Email).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull().MaximumLength(100)
                    .WithMessage("{PropertyName} no debe exceder de 100 caracteres!");
                RuleFor(u => u.UserName).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull().MaximumLength(25)
                    .WithMessage("{PropertyName} no debe exceder de 25 caracteres!");
                RuleFor(u => u.Password).NotEmpty().WithMessage("{PropertyName} es requerido!").NotNull().MaximumLength(25)
                    .WithMessage("{PropertyName} no debe exceder de 25 caracteres!");

            }
        }
        
}
