# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . .
RUN dotnet publish CarExplorer.API -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

ENTRYPOINT ["dotnet", "CarExplorer.API.dll"]