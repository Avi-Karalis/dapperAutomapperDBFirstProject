
using AdminPanel.Api.Mappers;
namespace AdminPanel.Api.DependencyResolver {
    public static class MapperConfiguration {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services) {

            services.AddAutoMapper(typeof(PersonMapper).Assembly);
            services.AddAutoMapper(typeof(UploadMapper).Assembly);
            return services;
        }
    }
}