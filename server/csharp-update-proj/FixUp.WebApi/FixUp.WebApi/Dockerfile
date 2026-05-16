FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj", "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/"]
COPY ["server/csharp-update-proj/FixUp.Repository/FixUp.Repository.csproj", "server/csharp-update-proj/FixUp.Repository/"]
COPY ["server/csharp-update-proj/FixUp.Service/FixUp.Service.csproj", "server/csharp-update-proj/FixUp.Service/"]

RUN dotnet restore "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj"

COPY . .

RUN dotnet publish "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "FixUp.WebApi.dll"]
