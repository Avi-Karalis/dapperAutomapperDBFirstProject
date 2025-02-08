FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY AdminPanel.sln . 
COPY AdminPanel.Api/AdminPanel.Api.csproj AdminPanel.Api/
COPY AdminPanel.ModelsAndRepository/AdminPanel.ModelsAndRepository.csproj AdminPanel.ModelsAndRepository/
COPY AdminPanel.Service/AdminPanel.Service.csproj AdminPanel.Service/
RUN dotnet restore

COPY . .

WORKDIR /app/AdminPanel.Api
RUN dotnet publish AdminPanel.Api.csproj -c Release -o /app/publish

# Final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 5025
ENTRYPOINT ["dotnet", "AdminPanel.Api.dll"]