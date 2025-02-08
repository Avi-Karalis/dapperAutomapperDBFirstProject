using Microsoft.Extensions.DependencyInjection;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Repositories;
namespace AdminPanel.ModelsAndRepository.DependencyResolver{
    public static class Repositories{
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IUploadRepository, UploadRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPersonalAccessTokenRepository, PersonalAccessTokenRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
            return services;
        }
    }
}