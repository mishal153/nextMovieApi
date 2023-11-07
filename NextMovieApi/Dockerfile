#runtime image?
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
EXPOSE 80
WORKDIR /app

# build code on separate image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /nextMovieApi
COPY . .
RUN dotnet clean NextMovieApi.csproj
RUN dotnet restore NextMovieApi.csproj
RUN dotnet publish "NextMovieApi.csproj" -c Release -o /publish

# the as is probably optional?
FROM base AS runtime

COPY --from=build /publish .

ENTRYPOINT ["dotnet", "NextMovieApi.dll"]