FROM microsoft/dotnet
MAINTAINER pedro.pinhal@gmail.com

WORKDIR /app

RUN dotnet new webapi

RUN dotnet restore

ENV ASPNETCORE_URLS http://*:5000

EXPOSE 5000

ENTRYPOINT dotnet run

# docker build -t demo .
# docker run -it -p 5000:5000 demo
# docker start -i -a container-name