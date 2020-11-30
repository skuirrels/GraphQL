#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
ENV ASPNETCORE_URLS http://+:6060
EXPOSE 6060

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["EF5_Core_API/EF5_Core_API.csproj", "EF5_Core_API/"]
RUN dotnet restore "EF5_Core_API/EF5_Core_API.csproj"
COPY . .
WORKDIR "/src/EF5_Core_API"
RUN dotnet build "EF5_Core_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EF5_Core_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EF5_Core_API.dll"]