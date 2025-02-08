using FluentValidation;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Validator {
    public class FilterValidator :AbstractValidator<Filter> {
        public FilterValidator() {
            RuleFor(f => f.Field)
                .NotEmpty()
                .WithMessage("Field must not be empty.");

            RuleFor(f => f.ConstraintOperator)
                .NotEmpty()
                .WithMessage("ConstraintOperator must not be empty.");

            RuleFor(f => f.Value)
                .NotNull()
                .WithMessage("Value must not be null.");
        }
    }
}
