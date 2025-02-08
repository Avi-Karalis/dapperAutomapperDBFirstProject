using FluentValidation;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Validator {
    public class QueryParamsValidator : AbstractValidator<QueryParameters> {
        public QueryParamsValidator() {
            RuleFor(p => p.PerPage).Must(PerPage => PerPage > 0).WithMessage("PerPage must be of integer value of 1 or higher");
            RuleFor(p => p.SortOrder).Must(sortOrder).WithMessage("Sort Order value must only be asc or desc");
            RuleFor(p => p.Page).Must(Page => Page > 0).WithMessage("Page must be of integer value of 1 or higher");
            RuleForEach(p => p.Filters).SetValidator(new FilterValidator());
        }

        private bool sortOrder(string? sortOrder) {
            if (sortOrder != null) {
                if (sortOrder.ToLower().Equals("asc") || sortOrder.ToLower().Equals("desc")) { return true; };
            }
            return false;
        }
    }
}
