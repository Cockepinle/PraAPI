FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["PraApi.sln", "./"]
COPY ["PraApi/PraApi.csproj", "PraApi/"]

RUN dotnet restore "PraApi.sln"

COPY PraApi/ PraApi/

RUN dotnet publish "PraApi/PraApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "PraApi.dll"]
