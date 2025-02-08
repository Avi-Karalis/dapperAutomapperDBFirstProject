using AdminPanel.Api.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;
namespace AdminPanel.Api.DependencyResolver
{
    public static class ValidatorConfiguration
    {
        public static IServiceCollection AddFluentValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<PersonCreateDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<UploadValidator>();
            return services;
        }
    }
}