FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore

COPY . ./
WORKDIR /app
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

ENV ASPNETCORE_URLS http://*:80

COPY --from=build /app/out ./
ENTRYPOINT [ "dotnet", "PlatformService.dll" ]