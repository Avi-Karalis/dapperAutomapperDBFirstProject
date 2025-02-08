using AdminPanel.Api.DependencyResolver;
using AdminPanel.ModelsAndRepository.DependencyResolver;
using AdminPanel.Service.DependencyResolver;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DotNetEnv;
using RequestTransformer.Middlewares;

Env.Load();
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IConfiguration jwtSettings = builder.Configuration.GetSection("Jwt");

string httpUrl = Environment.GetEnvironmentVariable("ASPNETCORE_HTTP");
string httpsUrl = Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS");
builder.WebHost.UseUrls([httpUrl, httpsUrl]);

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]))
    };
});
builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.CreateConnectionString().AddRepositories().AddServices().AddAutoMapperProfiles();
builder.Services.AddControllers();

builder.Services.AddFluentValidators();

WebApplication app = builder.Build();
app.UseMiddleware<RequestTransformationMiddleware>();
app.UseRouting();

app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

string[]summaries =[ "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" ];

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast(
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        )
    ).ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
