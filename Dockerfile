FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY /src .

RUN dotnet restore "$PROJECT_NAME.sln" 

FROM build AS publish
RUN dotnet publish "$PROJECT_NAME.sln" -c Release -o /app/publish

FROM base AS final
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "$PROJECT_NAME.dll"]
EXPOSE 5000


