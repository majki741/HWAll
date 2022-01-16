#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Mikolaj.Samulak.Service2.csproj", "Mikolaj.Samulak.Service2/"]
RUN dotnet restore "Mikolaj.Samulak.Service2/Mikolaj.Samulak.Service2.csproj"
COPY . "Mikolaj.Samulak.Service2/"
WORKDIR "/src/Mikolaj.Samulak.Service2"
RUN dotnet build "Mikolaj.Samulak.Service2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mikolaj.Samulak.Service2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mikolaj.Samulak.Service2.dll"]