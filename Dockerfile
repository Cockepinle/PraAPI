
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["PraApi/PraApi.csproj", "PraApi/"]
RUN dotnet restore "PraApi/PraApi.csproj"

COPY . .
WORKDIR "/src/PraApi"
RUN dotnet publish "PraApi.csproj" --no-restore -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PraApi.dll"]
