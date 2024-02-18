FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . .
RUN dotnet build -c Release src/calculator/calculator.csproj -o build
CMD ["dotnet", "build/calculator.dll"]