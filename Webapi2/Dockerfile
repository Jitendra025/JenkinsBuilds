#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Webapi2/Webapi2.csproj", "Webapi2/"]
RUN dotnet restore "Webapi2/Webapi2.csproj"
COPY . .
WORKDIR "/src/Webapi2"
RUN dotnet build "Webapi2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Webapi2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Webapi2.dll"]