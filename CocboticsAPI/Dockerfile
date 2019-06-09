FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["CocboticsAPI/CocboticsAPI.csproj", "CocboticsAPI/"]
RUN dotnet restore "CocboticsAPI/CocboticsAPI.csproj"
COPY . .
WORKDIR "/src/CocboticsAPI"
RUN dotnet build "CocboticsAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CocboticsAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CocboticsAPI.dll"]