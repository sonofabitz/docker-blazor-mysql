FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY MyBlazorServerTest.csproj .
RUN dotnet restore "MyBlazorServerTest.csproj"
COPY . .
RUN dotnet build "MyBlazorServerTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyBlazorServerTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyBlazorServerTest.dll"]