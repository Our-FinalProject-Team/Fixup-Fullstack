FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj", "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/"]
COPY ["server/csharp-update-proj/FixUp.Repository/FixUp.Repository.csproj", "server/csharp-update-proj/FixUp.Repository/"]
COPY ["server/csharp-update-proj/FixUp.Service/FixUp.Service.csproj", "server/csharp-update-proj/FixUp.Service/"]
COPY ["server/csharp-update-proj/FixUpSolution/FixUpSolution/FixUpSolution.csproj", "server/csharp-update-proj/FixUpSolution/FixUpSolution/"]

RUN dotnet restore "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj"

COPY . .

RUN dotnet publish "server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/FixUp.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .

COPY ["server/csharp-update-proj/FixUp.WebApi/FixUp.WebApi/professionalsSettings.json", "./"]

ENTRYPOINT ["dotnet", "FixUp.WebApi.dll"]
