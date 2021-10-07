FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Studnet/Studnet.csproj", "Studnet/"]
RUN dotnet restore "Studnet/Studnet.csproj"
COPY . .
WORKDIR "/src/Studnet"
RUN dotnet build "Studnet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Studnet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Studnet.dll"]
