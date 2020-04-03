#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["dispatch_system.csproj", ""]
RUN dotnet restore "./dispatch_system.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "dispatch_system.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dispatch_system.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dispatch_system.dll"]