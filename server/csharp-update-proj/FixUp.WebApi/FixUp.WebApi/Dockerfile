FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["FixUp.WebApi.csproj", "."]
RUN dotnet restore "FixUp.WebApi.csproj"

COPY . .
RUN dotnet publish "FixUp.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "FixUp.WebApi.dll"]
