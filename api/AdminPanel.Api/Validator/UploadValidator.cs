using FluentValidation;
using AdminPanel.Api.DTOs;
namespace AdminPanel.Api.Validator
{
    public class UploadValidator : AbstractValidator<Base64FileUploadDto>
    {
        public UploadValidator()
        {
            RuleFor(p => p.Base64Content).NotEmpty().WithMessage("Base64 File Upload DTO: Base64Content is required");
            RuleFor(p => p.FileName).NotEmpty().WithMessage("Base64 File Upload DTO: FileName is required").Must(BeValidFileType).WithMessage("Base64 File Upload DTO: Base64Content is not valid");
        }

        private static bool BeValidFileType(string fileName)
        {
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg", ".gif" };
            string fileExtension = Path.GetExtension(fileName).ToLower();
            return Array.Exists(allowedExtensions, ext => ext == fileExtension);
        }

    }
}