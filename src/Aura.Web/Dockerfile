
# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
#Copy the csproj file
COPY Aura.Web.csproj .
RUN dotnet restore 

COPY . . 
RUN dotnet publish "Aura.Web.csproj" -c Release -o /app/publish

# Production Stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# dotnet 8 has a new default port. open that port
EXPOSE 8080


ENTRYPOINT ["dotnet", "Aura.Web.dll"]


