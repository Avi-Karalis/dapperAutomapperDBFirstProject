using System.Data;
using DotNetEnv;
using MySqlConnector;
namespace AdminPanel.Api.DependencyResolver {
    public static class ConnectionStringExtension {
        public static IServiceCollection CreateConnectionString(this IServiceCollection services) {
            Env.Load();
            string connectionString = $"Host={Env.GetString("DB_HOST")};" +
                                      $"Port={Env.GetString("DB_PORT")};" +
                                      $"Database={Env.GetString("DB_NAME")};" +
                                      $"Username={Env.GetString("DB_USERNAME")};" +
                                      $"Password={Env.GetString("DB_PASSWORD")}";
            services.AddScoped<IDbConnection>(provider => new MySqlConnection(connectionString));

            return services;
        }

    }
}