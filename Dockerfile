# 1. Etapa de compilación (SDK 6.0)
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copiar archivos de proyecto y restaurar
COPY *.sln .
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del código y publicar
COPY . .
RUN dotnet publish -c Release -o out

# 2. Etapa de ejecución (Runtime 6.0)
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# IMPORTANTE: Asegúrate de que "Backend.dll" coincida con el nombre de tu proyecto
ENTRYPOINT ["dotnet", "Backend.dll"]