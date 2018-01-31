# Build stage
FROM microsoft/aspnetcore-build:latest as build-env
WORKDIR /api

COPY netcoreapp3.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -o /publish

# Runtime stage

FROM microsoft/aspnetcore:latest
WORKDIR /publish
COPY --from=build-env /publish .
#ENV ASPNETCORE_URLS http://+:80
ENTRYPOINT [ "dotnet", "netcoreapp3.dll" ]


# docker build -t aspnetcore/api:multi .
# docker run --rm -it -p 8080:80 aspnetcore/api:multi