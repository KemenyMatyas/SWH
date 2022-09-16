namespace SWH.MVC.Validator
{
    using System;
    using Data.Models;
    using FluentValidation;

    public class PersonDetailsValidation : AbstractValidator<Person>
    {
        public PersonDetailsValidation()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().NotNull()
                .MinimumLength(3);
            
            RuleFor(p => p.FirstName)
                .NotEmpty().NotNull()
                .MinimumLength(3); 
            
            RuleFor(p => p.LastName)
                .NotEmpty().NotNull()
                .MinimumLength(3);
            
            RuleFor(p => p.PlaceOfBirth)
                .NotEmpty().NotNull()
                .MinimumLength(3); 
            
            RuleFor(p => p.Domicile)
                .NotEmpty().NotNull()
                .MinimumLength(3);
            
            RuleFor(p => p.BirthDay).GreaterThan(DateTime.Parse("1900/01/01")); 
            
            RuleFor(p => p.Password)
                .NotEmpty().NotNull()
                .MinimumLength(7); 
        }
    }
}