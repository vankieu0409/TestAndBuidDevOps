#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TestAndBuidDevOps/TestAndBuidDevOps.csproj", "TestAndBuidDevOps/"]
COPY ["Domain/Domain.csproj", "Domain/"]
RUN dotnet restore "./TestAndBuidDevOps/TestAndBuidDevOps.csproj"
COPY . .
WORKDIR "/src/TestAndBuidDevOps"
RUN dotnet build "./TestAndBuidDevOps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./TestAndBuidDevOps.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestAndBuidDevOps.dll"]