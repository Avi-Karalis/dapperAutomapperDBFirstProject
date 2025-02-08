using Microsoft.Extensions.DependencyInjection;
using AdminPanel.Service.Interfaces;
using AdminPanel.Service.Services;
namespace AdminPanel.Service.DependencyResolver
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IIdentity_TokenService, TokenService>();
            return services;
        }
    }
}