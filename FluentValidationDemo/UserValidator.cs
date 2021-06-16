using FluentValidation;
using System;
using System.Collections.Generic;

namespace FluentValidationDemo
{
    public class UserValidator : AbstractValidator<UserModel>
    {       
        public UserValidator()
        {
            Include(new UserNameIsSpecified());
            Include(new LastNameDistinctThanName());
            Include(new PlateNumberSpecifiedIfHasCar());
            Include(new LastNameIsNotBlacklisted());
            Include(new UserIsOver18());
        }
    }

    public class UserNameIsSpecified : AbstractValidator<UserModel>
    {
        public UserNameIsSpecified()
        {
            RuleFor(user => user.Name)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage("No ha indicado el nombre de usuario.")
               .Length(2, 50)
               .WithMessage("{PropertyName} tiene {TotalLength} letras. Debe tener una longitud entre {MinLength} y {MaxLength} letras.");
        }
    }

    public class LastNameDistinctThanName : AbstractValidator<UserModel>
    {
        public LastNameDistinctThanName()
        {
            RuleFor(user => user.LastName).NotEqual(user => user.Name);
        }
    }

    public class PlateNumberSpecifiedIfHasCar : AbstractValidator<UserModel>
    {
        public PlateNumberSpecifiedIfHasCar()
        {
            RuleFor(user => user.PlateNumber).Length(7, 12).When(user => user.HasCar);
        }
    }

    public class LastNameIsNotBlacklisted : AbstractValidator<UserModel>
    {
        public LastNameIsNotBlacklisted()
        {
            List<string> blackListWords = new List<string>();
            RuleFor(user => user.LastName).Must(name => !blackListWords.Contains(name));
        }
    }

    public class UserIsOver18 : AbstractValidator<UserModel>
    {
        public UserIsOver18()
        {
            RuleFor(user => user.BirthDate)
                .Must(IsOver18)
                .WithMessage("Tiene que ser mayor de edad para poder registrarse.");
        }

        private bool IsOver18(DateTime birthDate)
        {
            return DateTime.Now.AddYears(-18) >= birthDate;
        }    
    }
}
