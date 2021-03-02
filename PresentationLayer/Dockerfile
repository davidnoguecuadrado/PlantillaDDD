FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY PresentationLayer/PresentationLayer.csproj PresentationLayer/
RUN dotnet restore PresentationLayer/PresentationLayer.csproj
COPY . .
WORKDIR /src/PresentationLayer
RUN dotnet build PresentationLayer.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PresentationLayer.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PresentationLayer.dll"]
