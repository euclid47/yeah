FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY YeahApi/YeahApi.csproj YeahApi/
RUN dotnet restore YeahApi/YeahApi.csproj
COPY . .
WORKDIR /src/YeahApi
RUN dotnet build YeahApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish YeahApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "YeahApi.dll"]
