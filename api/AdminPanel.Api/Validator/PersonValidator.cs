using FluentValidation;
using AdminPanel.Api.DTOs;
using System.Data;
namespace AdminPanel.Api.Validator
{
    public class PersonCreateDtoValidator : AbstractValidator<PersonCreateDto>
    {
        public PersonCreateDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Person Create DTO: Name is required").MaximumLength(50).WithMessage("Person Create DTO: Name can not be more than 50 characters");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Person Create DTO: Email is required").EmailAddress().WithMessage("Person Create DTO: Email is not in valid form");
        }

    }
    public class PersonUpdateDtoValidator : AbstractValidator<PersonUpdateDto>
    {
        public PersonUpdateDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Person Update DTO: Id is required").Must(id => id is int && id > 0).WithMessage("Person Update DTO: Id must be a positive integer");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Person Update DTO: Name is required").MaximumLength(50).WithMessage("Person Update DTO: Name can not be more than 50 characters");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Person Update DTO: Email is required").EmailAddress().WithMessage("Person Update DTO: Email is not in valid form");
        }
    }

    public class PersonDisplayDtoValidator : AbstractValidator<PersonDisplayDto>
    {
        public PersonDisplayDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Person Display DTO: Id is required").Must(id => id is int && id > 0).WithMessage("Person Display DTO: Id must be a positive integer");
        }
    }

    public class PersonGetDtoValidator : AbstractValidator<PersonGetDto>
    {
        public PersonGetDtoValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Person Get DTO: Id is required").Must(id => id is int && id > 0).WithMessage("Person Get DTO: Id must be a positive integer");
        }
    }

}