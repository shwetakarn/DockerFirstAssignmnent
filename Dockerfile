FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 3000:80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["microservice.csproj", "./"]
RUN dotnet restore "microservice.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "microservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "microservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "microservice.dll"]
