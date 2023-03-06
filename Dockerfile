FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["IGWebAPI.csproj", "./"]
RUN dotnet restore "IGWebAPI.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "IGWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IGWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IGWebAPI.dll"]
